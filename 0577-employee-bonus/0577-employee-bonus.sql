# Write your MySQL query statement below
SELECT Employee.name, Bonus.bonus 
FROM Employee
LEFT JOIN  Bonus ON Employee.empId = Bonus.empId
WHERE Bonus.bonus IS NULL or Bonus.bonus < 1000;