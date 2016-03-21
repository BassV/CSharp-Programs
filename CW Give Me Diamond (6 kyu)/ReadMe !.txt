This my solution to the problem below
http://www.codewars.com/kata/5503013e34137eeeaa001648

Description:

This kata is to practice simple string output. Jamie is a programmer, and girlfriend of James. She likes diamonds, and this time she expects String of diamond from James. As James doesn't know how to do it, he needs your help.

Task:

You need to print a shape on the screen using asterisk ("*") characters.

The shape that will be returned from print method resembles a diamond, where the number provided as input represents the number of *’s printed on the middle line. The line above and below will be centered and will have 2 less *’s than the middle line. This reduction by 2 *’s for each line continues until a line with a single * is printed at the top and bottom of the figure.

Return null if input is even number (as it is not possible to print diamond with even number).

Example: 
For the input 5, the diamond is
  *
 ***
*****
 ***
  *

