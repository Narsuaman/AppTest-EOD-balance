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

![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/b729998e-0547-4940-a9a1-ee25b3438ee9)

2. I had to create a seperate callable method to get values of TotalDebit, TotalCredit and EndOfDayBalance![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/c3c3a3b3-5bdf-4793-8839-735c2cb5c7ee)

3. All the above variables needed to be decimal struct type as conversion was not possible based on the errors in VS
![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/22d4426a-f9b9-4b4d-82a5-7732258b48af)

4. I had to make sure the numerical values i pull from Json (implemented in the classes to store these values) as decimal struct type
![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/975c2ddf-0046-44e8-bb7d-3b84d24bd0bf)

5. I also had to declare values that may not be used so i can correctly call the values into the code from Json. THis was also done as it may be useful in the future.
6. I founld an easier way to call the data from Json to the code Used Vs's handy tool(Edit>Paste Special>Paste Json as classes) This saved me a lot of time from the manual task.
7. After declaring values for return new AccountBalance{} I had to modify the code a little so the values can be passed on to our Account Balance class ![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/fb54adff-422e-472a-b14f-a0f05f8bcdc1)
8. Finally to start testing the code i added the file to the BIN folder to test if it works and called it in the main class
 ![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/ef210255-a576-4be2-91bb-4e37267083df)

9.I had to test each part of the code to make sure the code is getting executed correctly by adding test to the console using console.write line to observe the values of the variables used in the code. Also Added aline to output the value of TotalDebit, TotalCredit and EndOfDayBalance.

![image](https://github.com/Narsuaman/AppTest-EOD-balance/assets/137115409/2886acf7-0b87-4231-bd8f-6620eb9b3d90)

Note: THe output of the console seems to have 2 lines, I am not sure the reason for this, Maybe because of how i have declared " TotalDebit,  TotalCredit,  EndOfDayBalance" and then created a NEW object! escentially calling it first with the initial values and the second time after the calcualtions for EOD balance have run. 


