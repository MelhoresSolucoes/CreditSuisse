# CreditSuisse
Aplicativo console criado como resultado de uma tarefa solicitada para seleção de oportunidade de trabalho

![image](https://user-images.githubusercontent.com/96745777/156699836-a2453472-3269-457e-bbf2-5d7e7b5f40aa.png)


## Answer the Question 2:

### Question
A new category was created called PEP (politically exposed person). 
Also, a new bool property  IsPoliticallyExposed was created in the ITrade interface. 
A trade shall be categorized as PEP if  IsPoliticallyExposed is true. 
Describe in at most 1 paragraph what you must do in your design to account for this  new category.

### Answer
In the case of this source code, the solution would be to implement the IsPoliticallyExposed property (from the ITrade interface) in the Trade class, and including the new category "PEP" in the conditions of the GetCategory method.



