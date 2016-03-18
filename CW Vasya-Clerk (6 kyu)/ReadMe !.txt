This my solution to the problem below
http://www.codewars.com/kata/555615a77ebc7c2c8a0000b8

Description:

The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollars bill. A "Avengers" ticket costs 25 dollars.

Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.

Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the order people follow in the line?

Return YES, if Vasya can sell a ticket to each person and give the change. Otherwise return NO.

Examples:

// === C Sharp ===

Line.Tickets(new int[] {25, 25, 50}) // => YES
 Line.Tickets(new int[] {25, 50, 100, 25, 50}) // => YES
Line.Tickets(new int[] {25, 100})  
           // => NO. Vasya will not have enough money to give change to 100 dollars