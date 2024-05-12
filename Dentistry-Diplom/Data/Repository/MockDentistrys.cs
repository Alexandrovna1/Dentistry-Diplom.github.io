using Dentistry_Diplom.Data.Interfaces;
using Dentistry_Diplom.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dentistry_Diplom.Data.Repository
{
    public class MockDentistrys : IAllDentistry
    {
        private readonly IDentistryCategory _densCategory = new MockCategory();
        public IEnumerable<DentistryInfo> Dentistrys { 
            get
            {
                return new List<DentistryInfo>
                {
                    new DentistryInfo{
                        name = "Лечение кариеса",
                        shortDesc = " ",
                        longDesc = "Кариес - это распространенное заболевание зубов, вызванное бактериями, которые образуют кислоту из пищевых остатков в полости рта. Постепенно кислота разрушает эмаль, что приводит к образованию дефектов на поверхности зуба - кариозных полостей.",
                        img = "<https://i.pinimg.com/564x/05/7f/48/057f48509edc9816acab9a7cf40b9723.jpg>",
                        price = 4300,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(0)
                    },
                    new DentistryInfo{
                        name = "Лечение среднего кариеса",
                        shortDesc = "",
                        longDesc = "Новая приставка, позволяющая растянуть удовольствие на целый десяток. Понравится большинсту геймеров, которые впервые знакомяться с приставками",
                        img = "https://i.pinimg.com/564x/05/7f/48/057f48509edc9816acab9a7cf40b9723.jpg",
                        price = 4600,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(0)
                    },
                    new DentistryInfo{
                        name = "Лечение глубокого кариеса",
                        shortDesc = "",
                        longDesc = "Консоль старого поколения, поддержка которой прекращена давно. Прилагается для коллекционеров и ценителей старых моделей",
                        img = "https://i.pinimg.com/564x/05/7f/48/057f48509edc9816acab9a7cf40b9723.jpg",
                        price = 5000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(0)
                    },
                     new DentistryInfo{
                        name = "Реставрационный фронт",
                        shortDesc = "",
                        longDesc = "Лучшая приставка со стороны выгоды. Не уступает PlayStation 5",
                        img = "https://i.pinimg.com/564x/05/7f/48/057f48509edc9816acab9a7cf40b9723.jpg",
                        price = 5500,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(0)
                    },
                    new DentistryInfo{
                        name = "Лечение пульпита",
                        shortDesc = "",
                        longDesc = "Средне-бюджетный вариант для карамнной консоли. Будет по душе, если желаете сэкономить",
                        img = "/img/deck-img-card.png",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(1)
                    },
                     new DentistryInfo{
                        name = "Лечение периодонтита",
                        shortDesc = "",
                        longDesc = "Самый дорогой, но самый лучший вариант среди карманных приставок. Переживет не одно поколение",
                        img = "/img/rog-img-card.png",
                        price = 17000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(1)
                    },
                     new DentistryInfo{
                        name = "Удаление молочного зуба",
                        shortDesc = "",
                        longDesc = "Легкая, но старая приставочка. Увы, вышло из моды и прогресса",
                        img = "https://i.pinimg.com/564x/4a/86/47/4a86474abfff723146dceb0821698208.jpg",
                        price = 2000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(1)
                    },
                     new DentistryInfo{
                        name = "Удаление зуба мудрости",
                        shortDesc = "",
                        longDesc = "Ушедшее поколение приставок, но можно купить и в коллекцию",
                        img = "https://i.pinimg.com/564x/4a/86/47/4a86474abfff723146dceb0821698208.jpg",
                        price = 8000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(1)
                    },
                     new DentistryInfo{
                        name = "Удаление корня зуба",
                        shortDesc = "",
                        longDesc = "Портативная приставка с закрытой ос. Хочешь играть - плоти",
                        img = "https://i.pinimg.com/564x/4a/86/47/4a86474abfff723146dceb0821698208.jpg",
                        price = 3000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(1)
                    },
                     new DentistryInfo{
                        name = "Ортодонтическое лечение",
                        shortDesc = "",
                        longDesc = "Портативная приставка с закрытой ос. Хочешь играть - плоти",
                        img = "https://i.pinimg.com/564x/57/5e/89/575e897caed97e9e804030b7e4e1b23a.jpg",
                        price = 9000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(1)
                    },
                     new DentistryInfo{
                        name = "Имплантация",
                        shortDesc = "",
                        longDesc = "Портативная приставка с закрытой ос. Хочешь играть - плоти",
                        img = "https://i.pinimg.com/564x/b9/c7/2a/b9c72abff882b1460407899110bec53b.jpg",
                        price = 1000,
                        isFavourite = true,
                        available = true,
                        _Category = _densCategory.AllCategories.ToList().ElementAt(1)
                    },
                };
            }
        }

        public IEnumerable<DentistryInfo> getFavDentistry { get => throw new NotImplementedException(); }

        public DentistryInfo getSingleDentistry(int dentistryId)
        {
            throw new NotImplementedException();
        }
    }
}
