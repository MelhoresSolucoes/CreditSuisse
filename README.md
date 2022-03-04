# CreditSuisse
This console application was created to solve a problem of the following exercise:

## Problem: 
Categorize trades in a bank´s portfolio 
A bank has a portfolio of thousands of trades and they need to be categorized. A trade is a commercial negotiation  between a bank and a client. A trade has many characteristics, including: 
![image](https://user-images.githubusercontent.com/96745777/156818552-6ef5a317-2423-4fd2-bbe9-f9dc00205b0f.png)
 
Currently, there are three categories (in order of precedence): 
1. EXPIRED: Trades whose next payment date is late by more than 30 days based on a reference date which will  be given. 
2. HIGHRISK: Trades with value greater than 1,000,000 and client from Private Sector. 
3. MEDIUMRISK: Trades with value greater than 1,000,000 and client from Public Sector. 

## Question 1:
Write a C# console application using object oriented design that classifies all trades in a given portfolio. Keep in mind that the real application may have dozens of categories, so your design must be extensible allowing those categories to be easily added/removed/modified in the future. The code can be sent in a GitHub link. 

### Result: See the code.
![image](https://user-images.githubusercontent.com/96745777/156699836-a2453472-3269-457e-bbf2-5d7e7b5f40aa.png)


## Answer the Question 2:

### Question
A new category was created called PEP (politically exposed person). 
Also, a new bool property  IsPoliticallyExposed was created in the ITrade interface. 
A trade shall be categorized as PEP if  IsPoliticallyExposed is true. 
Describe in at most 1 paragraph what you must do in your design to account for this  new category.

### Answer
In the case of this source code, the solution would be to implement the IsPoliticallyExposed property (from the ITrade interface) in the Trade class, and including the new category "PEP" in the conditions of the GetCategory method.



