using System.Collections.Generic;
using System.Data.Entity;
using TheWorldCountries.Models;

namespace TheWorldCountries.DataAccess
{
    public class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        private List<Country> Countries;
        public DataInitializer()
        {
            Countries = new List<Country>
            {
                new Country
                {
                    Name="Казахстан",
                    Cities = new List<City>
                    {
                        new City
                        {
                            Name = "Нур-Султан",
                            Streets = new List<Street>
                            {
                                new Street
                                {
                                    Name = "Валиханова"
                                },
                                new Street
                                {
                                    Name = "Мангилик Ел"
                                }
                            }
                        },
                        new City
                        {
                            Name = "Павлодар",
                            Streets = new List<Street>
                            {
                                new Street
                                {
                                    Name = "Кутузова"
                                },
                                new Street
                                {
                                    Name = "Естая"
                                }
                            }
                        }

                    }
                },
                new Country
                {
                    Name="Австралия",
                    Cities = new List<City>
                    {
                        new City
                        {
                            Name = "Сидней",
                            Streets = new List<Street>
                            {
                                new Street
                                {
                                    Name = "Джордж Стрит"
                                },
                                new Street
                                {
                                    Name = "Блай Стрит"
                                }
                            }
                        },
                        new City
                        {
                            Name = "Мельбурн",
                            Streets = new List<Street>
                            {
                                new Street
                                {
                                    Name = "Грей стрит"
                                },
                                new Street
                                {
                                    Name = "Элизабет стрит"
                                }
                            }
                        }

                    }
                }
            };
        }
        protected override void Seed(DataContext context)
        {
            context.Countries.AddRange(Countries);
            base.Seed(context);
        }

    }
}