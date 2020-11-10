# MasGlobal, Hands on Test

This project was generated with a lot of love.


# Prerequisites

 ### Backend
 
1. Visual Studio 2017
2. .NetFramework 4.6.1

 ### Frontend

1. Nodejs 14.5 

# Install & Run
 
 ### Backend

1. Open Visual Studio 2017 and open MasGlobal.HandsOnTest.sln
2. Run the Proyect MasGlobal.HandsOnTest.Api 

 ### Frontend

1. Go to MasGlobal.HandsOnTest.Api/msglobal-handsontest
2. Install depedencies
		
        npm install

3. Run
    
        npm start

# Solution Architecture

## Backend

- Based on Onion Arquitecture and best practice of clean code

![alt text](https://tech.ovoenergy.com/content/images/2018/12/OnionLayersLabelled-2.png)


 ## Frontend

- MVVM Patterm
- https://angular.io/guide/styleguide

# Run Test

## Backend

- In Visual studio run tests


    Test Case| Status 
    --- | ---
    Given ContracType is Houryly And Salary is 20 Then return  28800| Succees 
    Given ContracType is Monthly And Salary is 2400 Then return  28800| Succees  
    Given ContracType is None  Then return  Excpetion | Succees  

#

# To do
## Backend
1. Implement Logger

## FrontEnd
1. Loading Component
3. Test componente 
