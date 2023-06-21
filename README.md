# AppTest-EOD-balance
Working code


#PDF Exercise Observations:

1. Following the coding exercise PDF i found a few issues with the code,
2. return new AccountBalance{} VARIABLES were not declared
3. return new AccountBalance{} had sintax was not correct.
4. To create a working code, I had to call data from the snipet in the PDF which i stored in a Json file for later use.
5. The Variables need to match from the Json to the code for proper inport of data using get set

#Action Plan

1. Create Classes and variables to be able to pull and translate dat from the Json to be used in the code
2. Import Json file into the code or make it inline so we can loose the file and have a standalone executable
3. Create Class to load the values from return new AccountBalance{} into the main code. This will allow the code to work
4. Load it on to Github

#Issues and observations of the code
1. I had to create a class AccountBalance to house the main method

![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/9d2d8704-bcde-41c6-a1c8-69b10192d39a)


2. I had to create a seperate callable CONSTRUCTOR to get values of TotalDebit, TotalCredit and EndOfDayBalance
![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/6d68b765-0ced-4e76-9617-0b7fe7a8503e)

3. All the above variables needed to be decimal struct type as conversion was not possible based on the errors in VS
![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/8edde95a-4d4b-400a-ae75-5413c85029db)

4. I had to make sure the numerical values i pull from Json (implemented in the classes to store these values) as decimal struct type
![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/2fc8ec27-a7dd-44dd-98fb-5bf4b6dc8ad0)

5. I also had to declare values that may not be used so i can correctly call the values into the code from Json. THis was also done as it may be useful in the future.
6. I found an easier way to call the data from Json to the code Used Vs's handy tool(Edit>Paste Special>Paste Json as classes) This saved me a lot of time from the manual task.
7. After declaring values for return new AccountBalance{} I had to modify the code a little so the values can be passed on to our Account Balance class 
![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/e2273d89-d156-45a9-a1f4-72ceb5983a63)

8. Finally to start testing the code i added the file to the BIN folder to test if it works and called it in the main class
![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/67c20da2-d9dc-40fe-80ca-60dd791ab57c)

9.I had to test each part of the code to make sure the code is getting executed correctly by adding test to the console using console.write line to observe the values of the variables used in the code. Also Added aline to output the value of TotalDebit, TotalCredit and EndOfDayBalance.

![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/f8cfc0af-5e79-4b44-9827-0f3502f00d28)


Note: THe output of the console seems to have 2 lines, I am not sure the reason for this, Maybe because of how i have declared " TotalDebit,  TotalCredit,  EndOfDayBalance" and then created a NEW object! escentially calling it first with the initial values and the second time after the calcualtions for EOD balance have run. 


