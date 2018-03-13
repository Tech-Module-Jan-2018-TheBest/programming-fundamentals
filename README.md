<h1>Exercises: C# Intro and Basic Syntax</h1>
Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">“Programming Fundamentals Extended” course @ SoftUni.</a>

<h3>Problem 1. Debit Card Number</h3>

Write a program, which receives **4 integers** on the
console and **prints them** in **4-digit debit card format**. See the
examples below for the appropriate formatting.

#### Examples

<table class="tg">
  <tr>
    <th class="tg-031e">Input</th>
    <th class="tg-031e">Output</th>
  </tr>
  <tr>
    <td class="tg-031e">12<br>433<br>1<br>5331</td>
    <td class="tg-031e">0012 0433 0001 5331<br></td>
  </tr>
  <tr>
    <td class="tg-031e">9182<br>4221<br>0012<br>0003</td>
    <td class="tg-031e">9182 4221 0012 0003</td>
  </tr>
  <tr>
    <td class="tg-031e">812<br>321<br>123<br>22</td>
    <td class="tg-031e">0812 0321 0123 0022</td>
  </tr>
</table>

<h3>Problem 2. Rectangle Area</h3>

Write a program, which calculates a **rectangle’s area**, based on its **width** and **height**. The **width** and **height** come as floating point numbers on the console, **formatted to the 2<sup>nd</sup> character after the decimal point**.

#### Examples

<table class="tg">
  <tr>
    <th class="tg-yw4l">Insert</th>
    <th class="tg-yw4l">Output</th>
  </tr>
  <tr>
    <td class="tg-jogk">2<br>7</td>
    <td class="tg-yw4l">14.00</td>
  </tr>
  <tr>
    <td class="tg-yw4l">7<br>8</td>
    <td class="tg-yw4l">56.00</td>
  </tr>
  <tr>
    <td class="tg-yw4l">12.33<br>5</td>
    <td class="tg-yw4l">61.65</td>
  </tr>
</table>

<h3>Problem 3. Miles to Kilometers</h3>

Write a program, which **converts miles** to **kilometers**. **Format** the output to the **2<sup>nd</sup> decimal place**.

Note: **1
mile == 1.60934 kilometers**

#### Examples

<table><tr><th>Input</th><th>Output</th></tr><tr><td>60</td><td>96.26</td></tr></table><table><tr><th>Input</th><th>Output</th></tr><tr><td>1</td><td>1.61</td></tr></table><table><tr><th>Input</th><th>Output</th></tr><tr><td>52.1113</td><td>83.86</td></tr> </table>

<h3>Problem 4. Beverage Labels</h3>

Write a program, which reads a food product **name** , **volume** , **energy content**** per 100ml **and** sugar content per 100ml **. Calculate the** energy **and** sugar content **for the** given volume** and print them on the console in the following format:

- Name – as per the input
- Volume – **integer** , **suffixed** by &quot; **ml**&quot; (e.g. &quot; **220ml**&quot;)
- Energy content – **integer** , **suffixed** by &quot; **kcal**&quot; (e.g. &quot; **500kcal**&quot;)
- Sugar content – **integer** , **suffixed** by &quot; **g**&quot; (e.g. &quot; **30g**&quot;)

### Examples

| Input                                         | Output                                             |
| --------------------------------------------- |:--------------------------------------------------:|
| Nuka-Cola<br/>220<br/>300<br/>70              |220ml Nuka-Cola:<br/>660kcal, 154g sugars           |

 
| Input                                         | Output                                             |
| --------------------------------------------- |:--------------------------------------------------:|
| Ice Cold Nuka-Cola<br/>250<br/>350<br/>65     |250ml Ice Cold Nuka-Cola:<br/>875kcal, 162.5g sugars|

| Input                                         | Output                                             |
| --------------------------------------------- |:--------------------------------------------------:|
| Nuka-Cola Quantum<br/>350<br/>600<br/>140     |350ml Nuka-Cola Quantum:<br/>2100kcal, 490g sugars  |

<h3>Problem 5. * Character Stats</h3>

Write a program, which **displays information** about a video game character. You will receive
their **name**, **current health**, **maximum health**, **current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal or lower** than their
respective **max** values). Print them in the format as per the examples.

### Examples

| Input                                         | Output                                             |
| --------------------------------------------- |:--------------------------------------------------:|
| Mayro<br/>5<br/>10<br/>9<br/>10               |Name: Mayro<br/>Health: \|\|\|\|\|\|.....\|<br/>Energy: \|\|\|\|\|\|\|\|\|\|.\|    |

| Input                                         | Output                                             |
| --------------------------------------------- |:--------------------------------------------------:|
| Bauser<br/>10<br/>10<br/>10<br/>10               |Name: Bauser<br/>Health: \|\|\|\|\|\|\|\|\|\|\|\|<br/>Energy: \|\|\|\|\|\|\|\|\|\|\|\|          |

| Input                                         | Output                                             |
| --------------------------------------------- |:--------------------------------------------------:|
| Loogi<br/>8<br/>20<br/>2<br/>14               |Name: Loogi<br/>Health: \|\|\|\|\|\|\|\|\|............\|<br/>Energy: \|\|\|............\|         |

| Input                                         | Output                                             |
| --------------------------------------------- |:--------------------------------------------------:|
| Toad<br/>0<br/>5<br/>0<br/>10               |Name: Toad<br/>Health: \|.....\|<br/>Energy: \|..........\|       |

### Hints

- You can print a character **multiple** times, using **new string(character, count)**.