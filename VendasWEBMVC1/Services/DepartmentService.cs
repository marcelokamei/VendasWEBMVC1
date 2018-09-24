using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWEBMVC1.Models;
using Microsoft.EntityFrameworkCore;


namespace VendasWEBMVC1.Services {
    public class DepartmentService {
        private readonly VendasWEBMVC1Context _context;

        public DepartmentService(VendasWEBMVC1Context context) {

            _context = context;

        }

        public async Task<List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
