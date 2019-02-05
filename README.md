# Retail
Тестовый проект для создания АРМ Кассира

## Краткое описание

В приложении использутся <b>IoC</b> контейнер на <b>autofac</b>.<br>
Настройка компонентов контейнера обеспечивается созданием в подключаемом модуле, файла <b>AutofacModule.cs</b>.<br>
Предпочтения отданы внедрениям в свойства (подобно <b>@Autowired</b> в <b>Spring</b>).<br>
Построение контейнера производится в отдельном модуле <b>Retail.IoC</b>. Там же имеется утилитарный класс с сервис локатором, который может быть использован на рантайм уровне, в случаях когда необходимо обойти циркулярные зависимости в момент внедрения свойств.<br>
Таким образом удается избежать цикрулярных зависимостей между сборками и обеспечить горизонтальный рост по функциональным модулям.
Новый модуль в таком случае обрастает всего лишь одной обязательной зависимостью от <b>Retail.Common.dll</b>.<br>

В приложении реализовано два уровня абстракции:<br>
<b>IApplication - функционал приложения.</b><br>
<b>IAction - любое действие в приложении.</b><br>

Если требуется новый функционал, то в первую очередь он должен добавлен в <b>Retail.Commom</b>.<br>
Вся новая логика должна начинать свой путь от декларации в модуле <b>Retail.Common</b> заканчивая имплементацией в новом (или существующем) модуле либо в основном модуле приложения (<b>Retail.Main</b>).

Интерфейс пользователя имеет компонентную структуру и разделен на отдельные <b>UserControl</b>. Каждый из которых реализует интерфейс для связи с другими контролами (как минимум <b>IDefaultControl</b>). 
Добавление контролов в контейнер также происходит через AutofacModule.cs.
Скажем <b>SomeControlA</b> реализующий <b>ISomeControlA</b>, хочет вызвать некий функционал модуля <b>SomeControlB</b> (реализующий <b>ISomeControlB</b>), тогда в нем должено быть объявлено свойство с публичным модификатором доступа:

```c#
class SomeControlA: ISomeControlA
{
	public ISomeControlB SomeControlB { get; set; }
      
  //Обновить контрол B
  private RefreshB()
  {
    this.SomeControlB.Refresh();
  }
}
```

Прикладная логика требующая обращения к БД, должна реализовывать <b>IRepository</b> с объявленным стандартным <i>CRUD</i> в декларации.


## Структура и назначение модулей
<b>Retail.Common</b> - Объявление функционала<br>
<b>Retail.Modeles</b> - Модели предметной области<br>
<b>Retail.IoC</b> - Сборка IoC-контейнера и доступ к нему<br>
<b>Retail.MicroORM</b> - Простой маппер для работы с БД (может быть заменен на Dapper)<br>
<b>Retail.Repository</b> - Реализация работы с БД<br>
<b>Retail.Controls</b> - UI-Контролы на базе WinForms<br>
<b>Retail.Controls.Wpf</b> - UI-Контролы на базе WPF(на данный момент не реализованы, модуль включем как демонстрация возможности использования UserControl на базе WPF)<br>
<b>Retail.UI.Themes</b> - Включает реализацию темы (различных тем оформления пользовательского интерфейса, в данной реализации идет как прототип)<br>
<b>Retail.Utils</b> - Модуль для размещения в нем статических утилитарных классов, так и хелперов расширяющих классы и интерфейсы (назначение его вынос повторяющегося кода)<br>


## Установка, сборка и запуск

Для создания БД <i>MySql</i> необходимой для работы программы выполните запуск файла
```
setupDb.cmd
```

Будет предложено ввести пароль администратора БД.<br>

Для сборки и установки запустите следующую последовательность команд<br>
```
MsBuild /P:Configuration=Release && call Retail.Main\bin\Release\Retail.Main.exe
```

Если <b>MsBuild</b> не найден, то путь к нему необходимо добавить в переменную окружения <b>PATH</b><br>
```
set PATH=%PATH%;c:\Windows\Microsoft.NET\Framework\v3.5\<br>
```
Также есть пакетный файл <b>setup.cmd</b> для единоразового запуска, который включает всю указанную цепочку команд<br>



