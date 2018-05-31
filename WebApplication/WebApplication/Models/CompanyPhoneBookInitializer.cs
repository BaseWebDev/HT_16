using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication.Models {
    public class CompanyPhoneBookInitializer: DropCreateDatabaseAlways<CompanyPhoneBook> {
        protected override void Seed(CompanyPhoneBook db) {
            var division = new Divison() { Name = "Управление" };
            Employee Ivanov = new Employee() {
                FirstName = "Иван",
                MiddleName = "Иванович",
                LastName = "Иванов",
                NumberHomePhone = "8-915-841-30-08",
                ExtensionPhone = new ExtensionPhone() {
                    Number = "432",
                    InstallationSite = "Здание Управления, 4 этаж, каб. 30"
                },
                Position = new Position() {
                    Name = "Главный экономист",
                    Subdivison = new Subdivison() {
                        Name = "Плановый отдел",
                        Divison = division
                    }
                }
            };
            db.Employees.Add(Ivanov);

            Employee Petrov = new Employee() {
                FirstName = "Петр",
                MiddleName = "Петрович",
                LastName = "Петров",
                NumberHomePhone = "8-985-834-23-76",
                ExtensionPhone = new ExtensionPhone() {
                    Number = "156",
                    InstallationSite = "Здание Управления, 2 этаж, каб. 11"
                },
                Position = new Position() {
                    Name = "Оператор ЭВМ",
                    Subdivison = new Subdivison() {
                        Name = "ОМТС",
                        Divison = division
                    }
                }
            };
            db.Employees.Add(Petrov);

            Employee Sidorov = new Employee() {
                FirstName = "Иван",
                MiddleName = "Станиславович",
                LastName = "Сидоров",
                NumberHomePhone = "8-910-123-38-07",
                ExtensionPhone = new ExtensionPhone() {
                    Number = "232",
                    InstallationSite = "Здание Управления, 3 этаж, каб. 25"
                },
                Position = new Position() {
                    Name = "Начальник отдела",
                    Subdivison = new Subdivison() {
                        Name = "Плановый отдел",
                        Divison = division
                    }
                }
            };
            db.Employees.Add(Sidorov);
            base.Seed(db);
        }
    }
}