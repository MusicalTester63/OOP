
SELECT * FROM Student
SELECT * FROM Predmet
SELECT * FROM Hodnoceni

Select * from Spojovacia


SELECT * 
FROM Student 
LEFT JOIN Spojovacia ON Student.id_student = Spojovacia.IdStudent



SELECT lastName, 
count(id_Student) as studentCount 
FROM Student group by lastName  
order by studentCount DESC



SELECT SubjectACR 
FROM Spojovacia 
group by SubjectACR
having count(IdStudent)<3



SELECT name_subject_rating,  
max(Rating) as highScore, 
min(Rating) as lowScore,
avg(Rating) as averageScore,
count(IdStudent_rating) as countScore
FROM Hodnoceni group by
name_subject_rating