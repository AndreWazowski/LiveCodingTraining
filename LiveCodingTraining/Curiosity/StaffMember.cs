using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining {

    public class Division {
        public EDivision Id { get; set; }
        public string Name { get; set; }
        public decimal IndiceCorrecao { get; set; }
    }


    public class StaffMember {
        public int EmployeeNumber { get; private set; }
        public string FullName { get; private set; }
        //public EDivision DivisionId { get; private set; }
        public decimal Wage { get; private set; }


        public virtual Division Division { get; private set; }


        public StaffMember(int employeeNumber, string fullName, EDivision division, decimal wage) {
            EmployeeNumber = employeeNumber;
            FullName = fullName;
            //DivisionId = division;
            Wage = wage;
        }

        public void Update( decimal wage, Division division) {
            Wage = wage;
            Division = division;

            Wage *= Division.IndiceCorrecao;
        }

        public void UpdateWage() {
            Wage *= Division.IndiceCorrecao;
        }

        //public void UpdateWage() {
        //    switch (DivisionId) {
        //        case EDivision.InformationTechnology:
        //            UpdateWage(1.10m);
        //            break;
        //        case EDivision.HumanResources:
        //            UpdateWage(0.90m);
        //            break;
        //    }
        //}

    }

    public enum EDivision {
        InformationTechnology = 1,
        HumanResources,
        Accounting
    }

    //public class Application {
    //    public static void Main(string[] args) {
    //        var staffMembers = new List<StaffMember>{
    //                                                    new (1, "Anna", EDivision.HumanResources, 50000),
    //                                                    new (2, "Brian", EDivision.InformationTechnology, 60000),
    //                                                    new (3, "Cathy", EDivision.Accounting, 55000),
    //                                                    new (4, "Dan", EDivision.InformationTechnology, 62000),
    //                                                    new (5, "Ella", EDivision.HumanResources, 48000)
    //                                                };
    //        /*
    //         Remover o laço que incrementa o atributo Wage, para as divisões InformationTechnology e  HumanResources, e incluir os if's no primeiro
    //         O calculo de salario ele deve ficar dentro da classe staffMember
    //         */

    //        // Sort staff members by division

    //        staffMembers = staffMembers.OrderBy(s => s.Division.Id).ToList();

    //        // Print staff member details
    //        foreach (var staffMember in staffMembers) {
    //            staffMember.UpdateWage();

    //            Console.WriteLine($"Employee Number: {staffMember.EmployeeNumber}, Name: {staffMember.FullName}, Division: {staffMember.Division.Id}, Wage: {staffMember.Wage}");
    //        }
    //    }
    //}

}
