using Dentistry_Diplom.Data.Interfaces;
using Dentistry_Diplom.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dentistry_Diplom.Data.Repository
{
    public class MockCategory : IDentistryCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Список наших специалистов", descr = "Терапевт, Хирург, Ортодонт, Ортопед"},
                    new Category { categoryName = "Терапевтическое отделение", descr = "Лечение кариеса, Лечение пульпита, Лечение периодонтита"},
                    new Category { categoryName = "Хирургическое отделение", descr = "Удаление, Флегмоны и абсцессы, Хирургические вмешательства "},
                    new Category { categoryName = "Ортодонтическое отделение", descr = "Исправление прикуса, Брекеты"},
                    new Category { categoryName = "Ортопедическое отделение", descr = "Протезирование, Коронки, Вкладки стоматологические"}
                };
            }
        }
    }
}
