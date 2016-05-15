﻿## Dungeon Dice Battles

Проект по визуелно програмирање од : Марко Зарев и Димитри Желков

##Опис:

Апликацијата е варијација на Dungeon Dice Monsters со тоа што овдека нема борби со чудовишта, туку само борба за територија и поени.

##Упатство за користење:

Апликацијата има лесен UI и е лесна за користење. При стартувањето се кликнува на копчето Start game и после се кликнува на gridot од левата страна. Со тоа се генерира gridot и коцките и играта е започната.

##Правила:

Има 3 вида коцки. 

-Summon2

-Summon3

-Summon4

Секој круг може да се расклопи еден вид на коцка. Но може да се расклопи уште една коцка (зависно од кој тип е (Summon2/3/4) различна коцка за секои тип) ако сите три коцки се од ист вид. За да се расклопи коцка на гридот содесен клик се клика на квадратот од гридот со што се селектира, се клика на која ориентација сакаме да ја ставиме коцката и се клика на Summon. Со ова ако е дозволено да се направи Summon (за да се расклопи коцка мора да започне расклопувањето од поле што веќе претходно е контролирано од играчот) и ако е можно на тој начин да се расклопи коцката (коцка неможе да се расклопи на туѓа или на веќе своја територија) коцката се расклопува и сите поени што биле на тие квадрати се додаваат на поените на играчот. За да се расклопи дополнителната коцка се клика на Summon+.Играта се игра се додека неможе веќе да се расклопуваат коцки при што играчот со повеќе поени победува.

##Решение на проблемот:

Апликацијата се состои од повеќе класи и тоа:

Form1: ова е главниот windows form кој се состои од повеќе методи кои се грижат за добра работа на апликацијата

1. panel1_Paint го црта гридот на апликацијата

2. generateGrid() го генерира гридот

3. PresmetajValue пресметува страна на коцката и нејзината вредност

4. Canyousummon проверува дали може да се расклопи коцката

5. endturn_Click го завршува кругот, повеќето методи се повикуваат во овој метод

6. validateSummon проверува дали смее да се расклопи коцката таму

7. summon_Click го повикува методот за цртањето на расклопувањето на коцката

8. SpawnPoint функција која генерира поени на рандом места во гридот

Igrac2: ова е класа во која се чуваат податоците за играчот.

DrawForm: класа која ги содржи сите коцки како низа.

Kocki: ова е класа каде што се иницијализира коцката.

##getTshape функцијата

Ова е една од главните функции која е дел од  цртањето на коцката. За променливи ги зима почетната коцка и насока во која треба да се црта коцката. Потоа во зависност од насоката ги менуваме двете локални промелниви coloX и colorY и инизијализираме низа од коцки. Во низата ги додаваме коцките кои треба да се обојат и функцијата после ги враќа нив за да може да се валидираат (дали може таму да се исцртаат коцките). Бидејќи секогаш играќ може да кликне да расклопи коцка надвор од гридот додадовме try catch блок кој проверува прво дали има такви коцки кои водат надвор од гридот и во случај да има тогаш функцијата враќа null за да не дојде до крашнување на апликацијата.