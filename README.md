# Екзамен
<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;">
    Министерство образования и науки РФ<br>
Государственное бюджетное профессиональное образовательное учреждение Республики Марий Эл<br>
Йошкар-Олинский технологический колледж
</td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;">
    <h2 style="font-size:3em;">Отчет</h2>
      <h3>по екзамеционной работе <br><br> по дисциплине "Основы алгоритмизации и программирования"<br><br> Тема:<b> "Пациенты"<b> </h3></td>
  </tr>
  <tr>
    <br><br><td style="text-align: right; border: none; height: 20em;">
      Разработал:<br/>
Попов Илья Александрович
      Группа: И-21<br>
      Преподаватель:<br>
      Колесников Евгений Иванович
    </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 5em;">
    г.Йошкар-Ола,<br> 2021</td>
  </tr>
</table>


# Цели и задачи:
Разработать WPF-приложение для пациентов включая данные Фамилия, Имя, Отчество, Адрес, Номер медицинской карты, Диагноз. 
Отчет скинуть преподавателю

  Вывод:Научился разрабатывать WPF-приложение,поиск,сортировку,фильтрацию по словарю.
# Что я делал:
1)Вставил разметку в окно ,сделал каркас приложения
2)Разработал таблицу и привязал к ней данные
 public IEnumerable<Med> GetMeds()
 ```

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
 ```
3)Сделал Фильтрацию по словарю
4)Релизовал  интерфейс INotifyPropertyChanged
 ```
public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
 private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("MedList"));
        }

 ```
5)Сделал Поиск и сортировку
 ```

        private string SearchFilter = "";

        private void SearchFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();

        }

        private void SearchFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }
    }
    }
    



 ```

# Вывод:Приложение  WPF  для пациэнтов разработано с таблицой,поиском,сортировкой
![](./125.png)
