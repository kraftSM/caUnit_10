# caUnit_10 Решение Unit 10 repository for HomeWork/testing
## caUnit_10  (не для проверки)
Приложение Unit10 рабочее для проверки конструкций теоретической части юнита (не для проверки)
--частично зачищено, для текущего использования, не для сдачи/просмотра

## caUnit10Hw10-1Ver0 (для проверки по состоянию 2023.01.31.)
приложение реализует задание1 Unit10 по минимому:(Interface+Try/Catch)
- Interface ICalculator
- class Calculator его реализующий 
- - простой калькулятор на ОДНУ операцию СЛОЖЕНИЕ
- Контроль ввода пользователя через Try/Catch в основном приложении
- - +Контроль через Try/Catch в функции преобразования (упрощенная реализация) 
- Сообщения из основного приложения

## caUnit10Hw2_2Ver0 (для проверки по состоянию 2023.01.31.)
приложение реализует задание2 Unit10 по минимому:(добавить в задание 1 Logger с цветом)
доработка проекта caUnit10Hw10-1Ver0. 
Добавлено
- Interface ILogger
- class Logger его реализующий
-      пока пишет только в консоль (+ свой цвет для исключений/Событий)
-      4 вида сообщений (3 тесктовых + 1 Exception) с их типизацией
- Основное приложения видит Logger и пишет через него Exception, но не ошибки логики
- class Calculator видит Logger и пишет через него события (упрощенная сборка сообщения)

## caUnit10Hw1-2 Решение по расширенному классу Calculator (не для проверки)
класс должен бы поодерживать
- более одной операции и/или управляться событиями
- - сейчас в состоянии эскизов/обдумывания, для будующих реализаций

## caUnit10Hw2_2 Решение по расширенному классу Logger (не для проверки)
класс должен бы поодерживать
- запись и в консоль и файл (.csv) в зависимости от типа сообщения (что-то уже сделано в Ver0)
- использовать DateTime в метках записей/именах Log-файлов
- реализовать(?) Start,Finish,Promt при консольном выводе
- управлять(?) направлением вывода для разных типов сообщений
- - сейчас в состоянии обдумывания, для будующих реализаций (Бот из Unit11)
