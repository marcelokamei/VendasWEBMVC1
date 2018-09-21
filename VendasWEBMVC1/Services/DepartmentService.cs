using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWEBMVC1.Models;


namespace VendasWEBMVC1.Services {
    public class DepartmentService {
        private readonly VendasWEBMVC1Context _context;

        public DepartmentService(VendasWEBMVC1Context context) {

            _context = context;

        }

        public List<Department> FindAll() {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
