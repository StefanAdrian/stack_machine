# stack_machine

 A <i>stack machine</i> is a simple system that performs arithmetic operations
 on an input string of numbers and operators. It contains a stack that
 can store an arbitrary number of 12-bit unsigned integers. Initially the
 stack is empty. The machine processes a string of characters in the
 following way:<br/><br/>
 - the characters of the string are processed one by one;<br/>
 - if the current character is a digit ('0'-'9'), the machine
 pushes the value of that digit onto its stack;<br/>
 - if the current character is '+', the machine pops the two
 topmost values from its stack, adds them and pushes the result
 onto the stack;<br/>
 - if the current character is '*', the machine pops the two
 topmost values from its stack, multiplies them and pushes the
 result onto the stack;<br/>
 - after the machine has processed the whole string it returns the
 topmost value of its stack as the result;<br/>
 - the machine reports an error if any operation it performs
 (addition or multiplication) results in an overflow;<br/>
 - the machine reports an error if it tries to pop an element from
 its stack when the stack is empty, or if the stack is empty
 after the machine has processed the whole string.<br/><br/>
 
 For example, given the string "13+62*7+*" the machine will perform the
 following operations:<br/><br/>

 <pre>
 
   character | comment                | stack
  -----------------------------------------------
             |                        | [empty]
  '1'        | push 1 onto the stack  |
             |                        | 1
  '3'        | push 3 onto the stack  |
             |                        | 1, 3
  '+'        | perform addition       |
             |                        | 4
  '6'        | push 6 onto the stack  |
             |                        | 4, 6
  '2'        | push 2 onto the stack  |
             |                        | 4, 6, 2
  '*'        | perform multiplication |
             |                        | 4, 12
  '7'        | push 7 onto the stack  |
             |                        | 4, 12, 7
  '+'        | perform addition       |
             |                        | 4, 19
  '*'        | perform multiplication |
             |                        | 76
  </pre>
 
 
  The machine will return 76 as the result as it is the topmost element of
  its stack.<br/><br/>
 
  Write a function:<br/>
 

       class Solution { public int solution(string S);
 <br/><br/>
 
  that, given a string S consisting of N characters containing input for
  the stack machine, returns the result the machine would return if given
  this string. The function should return −1 if the machine would report
  an error when processing the string.<br/><br/>
 
  For example, given string S = "13+62*7+*" the function should return 76,
  as explained in the example above. Given string S = "11++" the function
  should return −1.<br/><br/>
 
  Assume that:<br/>
  - the length of S is within the range [0..200,000];<br/>
  - string S consists only of the following characters: "0", "1",
  "2", "3", "4", "5", "6", "7", "8", "9", "+" and/or "*".<br/><br/>
 
  In your solution, focus on **correctness**. The performance of your
  solution will not be the focus of the assessment.<br/><br/>
 
 
 
