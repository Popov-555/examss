using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEX.Model
{
    public class LocalDataProvider : IDataProvider
    {

        public IEnumerable<Med> GetMeds()

        {
            return new Med[] {
                new Med{Name="Петров И.А",Address="г.Пермь",NumberMedicalСard="111",Diagnosis ="Здоровый" },
                new Med { Name = "Николаев П.П", Address = "г.Москва", NumberMedicalСard = "555",Diagnosis ="Здоровый" },
                new Med { Name = "Степанов А.А", Address = "г.Пермь",NumberMedicalСard = "777",Diagnosis ="Больной" },
                 new Med{Name="Вознесенский Л.Т",Address="г.Саратов",NumberMedicalСard="963",Diagnosis ="Здоровый" },
                  new Med{Name="Климов Ю.А",Address="г.Казань",NumberMedicalСard="444",Diagnosis ="Здоровый" },
                   new Med{Name="Савельев.Ю.Ю",Address="г.Чебоксары",NumberMedicalСard="784",Diagnosis ="Здоровый" },
                    new Med{Name="Антропов Ю.М",Address="г.Чебоксары",NumberMedicalСard="966",Diagnosis ="Больной" },
                     new Med{Name="Путинский.Д.Д",Address="г.Чебоксары",NumberMedicalСard="445",Diagnosis ="Больной" },
                      new Med{Name="Тычинов.М.М",Address="г.Чебоксары",NumberMedicalСard="7778",Diagnosis ="Больной" },
                       new Med{Name="Воротилов.С.С",Address="г.Чебоксары",NumberMedicalСard="4521",Diagnosis ="Больной" },
                        new Med{Name="Афанасьев.Ж.Ж",Address="г.Йошкар-Ола",NumberMedicalСard="4212",Diagnosis ="Больной" },
                         new Med{Name="Петухов.П.П",Address="г.Йошкар-Ола",NumberMedicalСard="1211",Diagnosis ="Больной" },
                          new Med{Name="Молочкин.А.А",Address="г.Йошкар-Ола",NumberMedicalСard="1212",Diagnosis ="Больной" },
                           new Med{Name="Краснов.Ю.Ю",Address="г.Йошкар-Ола",NumberMedicalСard="1245",Diagnosis ="Здоровый" },
                             new Med{Name="Молочкин.Ю.Ю",Address="г.Йошкар-Ола",NumberMedicalСard="1245",Diagnosis ="Здоровый" },
            };
        }
        public IEnumerable<MedDiagnoz> GetMedDiagnoz()
        {
            return new MedDiagnoz[] {
        new MedDiagnoz{ Title="Здоровый" },
        new MedDiagnoz{ Title="Больной" },
    };
        }


    }
}
