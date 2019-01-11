# LARP_Medicine_05012019
Medicine system which was used for Tapani Sector: Blue Blood LARP game at 05.01.2019.

Руководство по пользованию программой симулятора меддроида.

==СОДЕРЖАНИЕ==

0. Введение.
1. Заполнение базы данных.
  1.1. Принцип работы.
  1.2. Строка-комментарий.
  1.3. Данные о персонаже.
    1.3.1. ID персонажа.
    1.3.2. Титул.
    1.3.3. Имя.
    1.3.4. Фамилия.
    1.3.5. Состояние.
  1.4. Примеры.
2. Проведение операции.
  2.1. Описание процесса.
  2.2. СПОЙЛЕР: Лечение любых повреждений.
  2.3. Неочевидные аспекты.
	2.3.1. Криостазис.
	2.3.2. Характеристики.
	2.3.3. Заметки врача.
3. Изменение программы.
4. Авторство.

## Введение
Для работы программы понадобится .exe файл, собственно, программы, а также текстовый файл 'database.txt', лежащий рядом с программой.
## Заполнение базы данных.
### Принцип работы.

Чтобы программа исправно работала, необходимо рядом с ней поместить файл 'database.txt', содержащий данные о персонажах. В архиве присутствует файл заполненной базы данных с ролевой игры Сектор Тапани: Голубая Кровь (2019г), здесь же я поясню структуру данных.
Файл заполняется построчно. То есть, каждая строка файла обрабатывается независимо от остальных строк.

### Строка-комментарий.
  
В файле можно оставить какой-нибудь комментарий, поставив в самом начале строки знак '#' - в этом случае программа полностью проигнорирует строку. Например:

`# База данных ролевой игры *вставить название*.`

Эта строка не принесёт вреда файлу, и программа будет работать, игнорируя её.

### Данные о персонаже.

Чтобы внести данные о персонаже в базу, необходимо составить строку одного из следующих форматов:

`ID_персонажа#Титул#Имя#`
`ID_персонажа#Титул#Имя#Фамилия`
`ID_персонажа#Титул#Имя#Фамилия#Состояние`

#### ID_персонажа.

ID персонажа - его личный номер, который игрок должен знать. Он всегда состоит из четырёх (!!!) цифр, МОЖЕТ начинаться с нуля (можно использовать хоть 0000). 

#### Титул.

Игра проводилась про футуристическое титулованное дворянство, и у многих персонажей были титулы. Для персонажей без титула предусмотрен механизм отображения фразы "Нет титула" - для этого необходимо вместо титула ввести АБСОЛЮТО ЛЮБОЙ символ, ОДИН. Например:
`1234#%#Иван#Дурачок`

#### Имя и фамилия.

Тут мало что надо пояснять. Фамилия у персонажа может отсутствовать, для этого необходимо просто поставить на её месте пробел. А можно и ничего не ставить - главное, чтобы в строке было минимум три знака '#'.

#### Состояние.

* 0 - ЖИВ.
* 1 - МЁРТВ.
* 2 - ЗАМОРОЖЕН.

Отсутствие цифры автоматически расценивается как ЖИВой персонаж.

### Примеры полностью верно заполненных строк:

`7163#Барон#Андре#ле Штерн#0`
`1738#Лорд#Волан#де Морт#0`
`3632#%#Пётр#Сапогов#1`

## Проведение операции.
Нужно понять некоторые различия между терминами 'ранение' и 'повреждение' в рамках этой системы. 

Ранение - это ТИП УРОНА, который наносится ВО ВРЕМЯ ИГРЫ, будь то ранение световым мечом, перелом, или же удар молнией.
Повреждение - это РЕЗУЛЬТАТ ранения. Каждое ранение каждой степени тяжести имеет свой набор повреждений, который медику необходимо вылечить для успешного завершения операции.

### Описание процесса.
Операция, как уже было сказано выше, заключается в залечивании полученных повреждений. Осуществляется оно посредством выполнения медиком различных действий (нажатия на кнопки) в определённом порядке (для каждого повреждения - свой порядок). При этом ошибки (2+) караются различными последствиями после операции. Смерть пациента наступает при множестве ошибок, совершенных при лечении одного повреждения. Но ошибки с лечения другого повреждения также будут влиять на состояние пациента. После определённого количества ошибок, пациент окажется в критическом состоянии, о чём просигналит система, и следующая ошибка убьёт его.
### СПОЙЛЕР: Лечение любых повреждений.
* Ожог:               Фосован-соль => Удалить поражённые участки кожи => Лечебный кожный герметик
* Открытая рана:      Фосован-соль => Зашить рану
* Перелом:            Лечебный кожный герметик => Вправить кость => Нанести фиксирующую повязку
* Повреждение сосуда: Фосован-соль => Выполнить надрез => Рилл => Соединить сосуд => Зашить рану
* Повреждение нерва:  Фосован-соль => Выполнить надрез => Стимулятор => Соединить нерв => Зашить рану
## Неочевидные аспекты.
### Криостазис.
Персонажа можно ввести в криостазис. Для этого необходимо начать операцию, а затем отменить её. Программа предупредит пользователя о том, что при отмене операции дроид автоматически заморозит пациента. 
Разморозку можно провести в любой момент, вновь открыв окно информации о пациенте, и нажав кнопку "Разморозить".
### Характеристики.
Стандартные характеристики пациентов (давление, пульс, кровь) на самом деле генерируются сразу после чтения программой базы данных, основываясь на небольшом факторе рандома. Если закрыть программу и открыть заново - стандартные характеристики пациентов изменятся, так как они не были сохранены в базу.
### Заметки врача.
В окне просмотра информации о пациенте можно писать какие-нибудь заметки. Однако, они не сохранятся при перезапуске программы.



## Контакты:
Автором системы является Игорь "Asdolg" Гринкевич. 

ВКонтакте - https://vk.com/dustass 
Почта - defrasmaker@gmail.com

Программа сделана на языке C# с помощью компонентов Windows Forms и собрана в Microsoft Visual Studio Community 2017.
