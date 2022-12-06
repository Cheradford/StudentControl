using StudentControl.Infastructure;
using StudentControl.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentControl.Infrastructure.Repository
{
    public class PersonRepository
    {
        private readonly Context _context;

        public Context UnitOfWork { get { return _context; } }

        public PersonRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public void ChangeTrackerClear()
        {
            _context.ChangeTracker.Clear();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(Guid id)
        {
            return await _context.Students.Where(p => p.Id == id)
                .Include(p => p.Orders)
                .FirstOrDefaultAsync();
        }


        public async Task<Student?> GetByNameAsync(string name)
        {
            return await _context.Students
                .Where(p => p.Name == name)
                .Include(p => p.Orders)
                .FirstOrDefaultAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            Student? student = await _context.Students.FindAsync(id);

            if (student != null)
            {
                _context.Remove(student);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Student student)
        {
            var existStudent = GetByIdAsync(student.Id).Result;
            if (existStudent != null)
            {
                _context.Entry(existStudent).CurrentValues.SetValues(student);
                foreach(var Order in student.Orders)
                {
                    var existOrder = existStudent.Orders.FirstOrDefault(ord => ord.Id == Order.Id);

                    if(existOrder == null)
                    {
                        existStudent.Orders.Add(Order);
                    }
                    else
                    {
                        _context.Entry(existOrder).CurrentValues.SetValues(Order);
                    }

                    foreach (var existStudnetOrder in existStudent.Orders)
                    {
                        _context.Remove(existStudnetOrder);
                    }

                    await _context.SaveChangesAsync();

                }
            }
        }

    }
}
