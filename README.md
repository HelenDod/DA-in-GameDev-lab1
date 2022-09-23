# Лабораторная работа. Основы работы в среде разработки игр и интерактивных приложений. Основы работы c Unity.
Отчет по лабораторной работе #1 выполнила:
- Додонова Елена Игоревна
- РИ300002
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

## Цель работы
Ознакомиться с основными функциями взаимодействием с объектами внутри редактора.

## Задание 1
### В разделе «ход работы» пошагово выполнить каждый пункт с описанием ипримера реализации задач по теме видео самостоятельной работы.
Ход работы:
1) Создать новый проект из шаблона 3D; 
[![1571.png](https://i.postimg.cc/NMBbSQBD/1571.png)]

2) Проверить, что настроена интеграция редактора Unity и Visual Studio Code
image.png

3) Создать объект Plane;
image.png

4) Создать объект Cube;
image.png

5) Создать объект Sphere;
image.png

6) Установить компонент Sphere Collider для объекта Sphere;
image.png

7) Настроить Sphere Collider в роли триггера;
image.png

8) Объект куб перекрасить в красный цвет;
image.png

9) Добавить кубу симуляцию физики, при это куб не должен проваливаться под Plane;
image.png

10) Написать скрипт, который будет выводить в консоль сообщение о том,
что объект Sphere столкнулся с объектом Cube;
image.png
image.png

11) При столкновении Cube должен менять свой цвет на зелёный, а при
завершении столкновения обратно на красный.
image.png
image.png
image.png

## Задание 2
### Продемонстрируйте на сцене в Unity следующее:
- Что произойдёт с координатами объекта, если он перестанет быть
дочерним?
- Создайте три различных примера работы компонента RigidBody?

Ход работы:
1) Сфера дочерний объект куба.
image.png

Сфера перестала быть дочерним объектом.
image.png

Координаты объекта изменились, так как он перестал зависеть от объекта, который был для него родительским.


2) Создайте три различных примера работы компонента RigidBody?
У шара включена гравитация, поэтому при запуске сцены этот объект падает.
image.png
image.png

У куба включена кинематика, поэтому при запуске данный объект временно нефизический, на него не действуют столкновения.
image.png

Куб в данном случае закреплён по всем трём координатам, поэтому при соприкосновении с объектом он не улетает, а просто вращается на месте.
image.png
image.png

## Задание 3
### Реализуйте на сцене генерацию n кубиков. Число n вводится пользователем после старта сцены.
 Ход работы:
 1) Создать ImputField.
 image.png






## Выводы

Абзац умных слов о том, что было сделано и что было узнано.

