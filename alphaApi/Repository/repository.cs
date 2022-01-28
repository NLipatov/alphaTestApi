using alphaApi.DTOs;
using alphaApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; 

namespace alphaApi.Repository
{
    public class repository : Irepository
    {
        static DateTime pseudoFiredDate = new DateTime(2099, 1, 1);


        //Employees 
        private readonly List<Employee> alphaEmployees = new()
        {
            new Employee
            {
                FullName = "Евсеев Леонард Матвеевич",
                DateIn = new DateTime(2021, 2, 23),
                DateOut = pseudoFiredDate,
                Id = 9111,
                DepartmentId = 11,
                Gender = 1,
                isManager = true,
                Login = @"ALPHA\Evseev",
                PhoneNumber = "7-605-452-81-36"
            },
            new Employee
            {
                FullName = "Лукин Орест Лаврентьевич",
                DateIn = new DateTime(2021, 2, 23),
                DateOut = pseudoFiredDate,
                Id = 9112,
                DepartmentId = 11,
                Gender = 1,
                isManager = false,
                Login = @"ALPHA\Lukin",
                PhoneNumber = "7-950-626-96-29"
            },

            new Employee
            {
                FullName = "Лихачёва Рамина Гордеевна",
                DateIn = new DateTime(2021, 3, 8),
                DateOut = pseudoFiredDate,
                Id = 9121,
                DepartmentId = 12,
                Gender = 0,
                isManager = true,
                Login = @"ALPHA\Likhachova",
                PhoneNumber = "7-235-237-85-76"
            },
            new Employee
            {
                FullName = "Вишнякова Леся Авксентьевна",
                DateIn = new DateTime(2021, 3, 10),
                DateOut = new DateTime(2099, 1, 1),
                Id = 9122,
                DepartmentId = 12,
                Gender = 0,
                isManager = false,
                Login = @"ALPHA\Vishnyakova",
                PhoneNumber = "7-623-457-85-55"
            },

            new Employee
            {
                FullName = "Лихачёва Рамина Гордеевна",
                DateIn = new DateTime(2021, 3, 8),
                DateOut = pseudoFiredDate,
                Id = 91211,
                DepartmentId = 12,
                Gender = 0,
                isManager = true,
                Login = @"ALPHA\Likhachova",
                PhoneNumber = "7-235-237-85-76"
            },
            new Employee
            {
                FullName = "Вишнякова Леся Авксентьевна",
                DateIn = new DateTime(2021, 3, 10),
                DateOut = pseudoFiredDate,
                Id = 91212,
                DepartmentId = 12,
                Gender = 0,
                isManager = false,
                Login = @"ALPHA\Vishnyakova",
                PhoneNumber = "7-623-457-85-55"
            }
        };
        private readonly List<Employee> betaEmployees = new()
        {
            new Employee
            {
                FullName = "Ильин Елисей Платонович",
                DateIn = new DateTime(2021, 1, 10),
                DateOut = pseudoFiredDate,
                Id = 9211,
                DepartmentId = 21,
                Gender = 1,
                isManager = true,
                Login = @"ALPHA\Ilin",
                PhoneNumber = "7-583-455-45-77"
            },
            new Employee
            {
                FullName = "Гришин Дмитрий Артемович",
                DateIn = new DateTime(2021, 1, 10),
                DateOut = pseudoFiredDate,
                Id = 9212,
                DepartmentId = 21,
                Gender = 1,
                isManager = false,
                Login = @"ALPHA\Grishin",
                PhoneNumber = "7-512-487-46-12"
            },


            new Employee
            {
                FullName = "Носов Леонид Павлович",
                DateIn = new DateTime(2021, 1, 15),
                DateOut = pseudoFiredDate,
                Id = 92111,
                DepartmentId = 211,
                Gender = 1,
                isManager = true,
                Login = @"ALPHA\Nosov",
                PhoneNumber = "7-903-039-39-19"
            },
            new Employee
            {
                FullName = "Щербаков Адольф Максович",
                DateIn = new DateTime(2021, 1, 20),
                DateOut = pseudoFiredDate,
                Id = 92112,
                DepartmentId = 211,
                Gender = 1,
                isManager = false,
                Login = @"ALPHA\Scherbakov",
                PhoneNumber = "7-562-489-12-12"
            },

            new Employee
            {
                FullName = "Беспалов Исаак Станиславович",
                DateIn = new DateTime(2021, 1, 23),
                DateOut = pseudoFiredDate,
                Id = 921111,
                DepartmentId = 2111,
                Gender = 1,
                isManager = true,
                Login = @"ALPHA\Bespalov",
                PhoneNumber = "7-323-453-19-99"
            },
            new Employee
            {
                FullName = "Мишин Прохор Иосифович",
                DateIn = new DateTime(2021, 1, 25),
                DateOut = pseudoFiredDate,
                Id = 921112,
                DepartmentId = 2111,
                Gender = 1,
                isManager = false,
                Login = @"ALPHA\Mishin",
                PhoneNumber = "7-562-489-12-12"
            },

            new Employee
            {
                FullName = "Мамонтов Аскольд Игоревич",
                DateIn = new DateTime(2021, 1, 23),
                DateOut = pseudoFiredDate,
                Id = 921121,
                DepartmentId = 2111,
                Gender = 1,
                isManager = true,
                Login = @"ALPHA\Mamontov",
                PhoneNumber = "7-243-546-55-42"
            },
            new Employee
            {
                FullName = "Марков Иосиф Иванович",
                DateIn = new DateTime(2021, 1, 25),
                DateOut = pseudoFiredDate,
                Id = 921122,
                DepartmentId = 2111,
                Gender = 1,
                isManager = false,
                Login = @"ALPHA\Markov",
                PhoneNumber = "7-234-489-12-12"
            },
        };
        private readonly List<Employee> gammaEmployees = new()
        {
            new Employee
            {
                FullName = "Игнатова Виталина Ивановна",
                DateIn = new DateTime(2021, 2, 23),
                DateOut = pseudoFiredDate,
                Id = 9311,
                DepartmentId = 31,
                Gender = 0,
                isManager = true,
                Login = @"ALPHA\Ignatova",
                PhoneNumber = "7-325-444-55-42"
            },
            new Employee
            {
                FullName = "Субботина Сильвия Аристарховна",
                DateIn = new DateTime(2021, 2, 25),
                DateOut = pseudoFiredDate,
                Id = 9312,
                DepartmentId = 31,
                Gender = 0,
                isManager = false,
                Login = @"ALPHA\Subbotina",
                PhoneNumber = "7-204-409-57-21"
            },
            new Employee
            {
                FullName = "Красильников Тимофей Егорьевич",
                DateIn = new DateTime(2021, 7, 25),
                DateOut = new DateTime(2021, 8, 1),
                Id = 9313,
                DepartmentId = 31,
                Gender = 1,
                isManager = false,
                Login = @"ALPHA\Krasilnikov",
                PhoneNumber = "7-235-777-87-77"
            },


            new Employee
            {
                FullName = "Цветкова Луиза Мэлоровна",
                DateIn = new DateTime(2021, 2, 26),
                DateOut = pseudoFiredDate,
                Id = 93111,
                DepartmentId = 311,
                Gender = 0,
                isManager = true,
                Login = @"ALPHA\Tsvetkova",
                PhoneNumber = "7-568-468-55-45"
            },
            new Employee
            {
                FullName = "Воронова Августина Пётровна",
                DateIn = new DateTime(2021, 2, 25),
                DateOut = pseudoFiredDate,
                Id = 93112,
                DepartmentId = 311,
                Gender = 0,
                isManager = false,
                Login = @"ALPHA\Voronova",
                PhoneNumber = "7-587-995-89-87"
            },

            new Employee
            {
                FullName = "Уваров Михаил Дмитриевич",
                DateIn = new DateTime(2021, 1, 16),
                DateOut = pseudoFiredDate,
                Id = 93121,
                DepartmentId = 312,
                Gender = 1,
                isManager = true,
                Login = @"ALPHA\Uvarov",
                PhoneNumber = "7-322-765-55-45"
            },
            new Employee
            {
                FullName = "Шарапова Ядвига Якуновна",
                DateIn = new DateTime(2021, 1, 19),
                DateOut = pseudoFiredDate,
                Id = 93122,
                DepartmentId = 312,
                Gender = 0,
                isManager = false,
                Login = @"ALPHA\Sharapov",
                PhoneNumber = "7-326-598-89-87"
            },

            new Employee
            {
                FullName = "Ефимова Леся Тимофеевна",
                DateIn = new DateTime(2021, 1, 23),
                DateOut = pseudoFiredDate,
                Id = 93131,
                DepartmentId = 313,
                Gender = 0,
                isManager = true,
                Login = @"ALPHA\Uvarov",
                PhoneNumber = "7-987-456-23-45"
            },
            new Employee
            {
                FullName = "Родионова Каролина Васильевна",
                DateIn = new DateTime(2021, 1, 29),
                DateOut = pseudoFiredDate,
                Id = 93132,
                DepartmentId = 313,
                Gender = 0,
                isManager = false,
                Login = @"ALPHA\Sharapov",
                PhoneNumber = "7-548-663-89-87"
            }
        };


        //Departments
        private readonly List<Department> departments = new()
        {
            new Department
            {
                FirmId = 1,
                BeginDate = new DateTime(2021, 2, 23),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 11,
                ManagerId = 9111,
                ParentId = null,
                Title = "Административный отдел Альфа"
            },

            new Department
            {
                FirmId = 1,
                BeginDate = new DateTime(2021, 3, 8),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 12,
                ManagerId = 9121,
                ParentId = 11,
                Title = "Бухгалтерия"
            },
            new Department
            {
                FirmId = 1,
                BeginDate = new DateTime(2021, 3, 8),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 121,
                ManagerId = 91212,
                ParentId = 12,
                Title = "Группа ведения отчётности"
            },

            // 

            new Department
            {
                FirmId = 2,
                BeginDate = new DateTime(2021, 1, 10),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 21,
                ManagerId = 9211,
                ParentId = null,
                Title = "Административный отдел Бета"
            },

            new Department
            {
                FirmId = 2,
                BeginDate = new DateTime(2021, 1, 11),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 211,
                ManagerId = 9221,
                ParentId = 21,
                Title = "Отдел разработки информационных систем"
            },

            new Department
            {
                FirmId = 2,
                BeginDate = new DateTime(2021, 1, 11),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 2111,
                ManagerId = 9221,
                ParentId = 21,
                Title = "Группа разработки"
            },
            new Department
            {
                FirmId = 2,
                BeginDate = new DateTime(2021, 1, 11),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 2112,
                ManagerId = 9221,
                ParentId = 21,
                Title = "Группа поддержки"
            },
            //

            new Department
            {
                FirmId = 3,
                BeginDate = new DateTime(2021, 2, 1),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 31,
                ManagerId = 9311,
                ParentId = null,
                Title = "Административный отдел Гамма"
            },

            new Department
            {
                FirmId = 3,
                BeginDate = new DateTime(2021, 2, 5),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 311,
                ManagerId = 9321,
                ParentId = 31,
                Title = "Юридический отдел"
            },
            new Department
            {
                FirmId = 3,
                BeginDate = new DateTime(2021, 1, 10),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 312,
                ManagerId = 9331,
                ParentId = 311,
                Title = "Отдел досудебных разбирательств"
            },
            new Department
            {
                FirmId = 3,
                BeginDate = new DateTime(2021, 1, 10),
                DisbandDate = new DateTime(2099, 1, 1),
                Id = 313,
                ManagerId = 9341,
                ParentId = 311,
                Title = "Отдел судебных разбирательств"
            },
        };


        //Companies
        private readonly List<Firm> firms = new()
        {
            new Firm { Id = 1, Title = "Alpha" },
            new Firm { Id = 2, Title = "Beta" },
            new Firm { Id = 3, Title = "Gamma" }
        };


        public List<Employee> GetActiveEmployees()
        {
            List<Employee> allWorkersList = new();
            return allWorkersList.Concat(alphaEmployees).Concat(betaEmployees).Concat(gammaEmployees).ToList();
        }
        public List<Employee> GetActiveEmployees(int departmentId)
        {
            List<Employee> allWorkersList = new();
            allWorkersList.Concat(alphaEmployees.Where(x => x.DepartmentId == departmentId))
                .Concat(alphaEmployees.Where(x => x.DepartmentId == departmentId))
                .Concat(alphaEmployees.Where(x => x.DepartmentId == departmentId)).ToList().RemoveAll(x => x.DateOut.CompareTo(pseudoFiredDate) == 0);
            return allWorkersList;
        }


        public string GetFirmTitleById(int id, List<Firm> Firms)
        {
            Firm firmWithGivenId = firms.FirstOrDefault(x => x.Id == id);
            if (firmWithGivenId != null)
            {
                return firmWithGivenId.Title;
            }
            return "N/A";
        }
        public string GetDepartmentTitleById(int id, List<Department> departments)
        {
            Department departmentWithGivenId = departments.FirstOrDefault(x => x.Id == id);
            if (departmentWithGivenId != null)
            {
                return departmentWithGivenId.Title;
            }
            return "N/A";
        }
        public List<DepartmentsAndManagersByFirtmDTO> GetManagersAndDepartmentsByFirmId(int id)
        {
            List<Employee> employees = GetActiveEmployees();
            employees.RemoveAll(x => x.isManager == false);
            List<DepartmentsAndManagersByFirtmDTO> resultingList = employees.Select(x => new DepartmentsAndManagersByFirtmDTO
            {
                FirmId = x.DepartmentId.ToString()[0],
                FirmTitle = GetFirmTitleById(x.DepartmentId.ToString()[0], firms),
                DepartmentId = x.DepartmentId,
                DepartmentTitle = GetDepartmentTitleById(x.DepartmentId, departments),
                Fullname = x.FullName
            }).ToList();
            return resultingList;
        }
        public List<Department> subDeps = new();
        public List<Department> GetDepartmentSubDepartmentsList(int id)
        {
            subDeps.AddRange(departments.Where(x => x.ParentId == id));
            foreach (var department in subDeps)
            {
                GetDepartmentSubDepartmentsList(department.Id);
            }
            List<Department> resultingList = JsonConvert.DeserializeObject<List<Department>>(JsonConvert.SerializeObject(subDeps));
            subDeps.Clear();
            return resultingList;
        }
        public List<Employee> GetManagerSubordinates(int id)
        {
            List<Department> subordinateDepartments = GetDepartmentSubDepartmentsList(id);

            List<Employee> subordinateEmployees = new();
            foreach (var department in subordinateDepartments)
            {
                subordinateEmployees.AddRange(GetActiveEmployees(department.Id));
            }
            return subordinateEmployees;
        }
    }
}
