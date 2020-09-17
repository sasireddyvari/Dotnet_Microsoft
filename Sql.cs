/*

select * from titles

--1--

select titles.title_id as " title id",titles.price as "old price",titles.price*1.2 as "newprice" from titles

--2--

select titles.title as name from titles where titles.price>20 and titles.price<55

--3--
select * from employee

select * from employee where employee.hire_date>'1-12-90' and (Year(GetDate())-Year(hire_date)) between 4 and 6

--4--
 select emp.hire_date from employee emp 

 --7--
 select * from authors
 select * from titleauthor
 select * from pub_info
 select * from publishers
 select t.title,p.city from titles t join publishers p  on t.pub_id=p.pub_id where city like'B%'

 --6--

 select * from employee
 select e.emp_id,Year(e.hire_date) as yearofjoining from employee e

 --8--
 select * from titles
 select * from publishers
  select * from titleauthor
   select * from pub_info
   select t.title,p.pub_name from titles t inner join publishers p on t.pub_id=p.pub_id where title like 'Net%'

   --9--
    select * from publishers
	 select * from sales
	 select * from titles
	 select t.ytd_sales,t.title from titles t inner join publishers p on t.pub_id=p.pub_id where p.pub_name like 'New Moon Books'

	 --10--

	 select t.title,p.city,p.pub_name from titles t join publishers p on t.pub_id=p.pub_id where city like 'B%'

	 --11--
	 select * from employee
	 select e.emp_id from employee e where Year(hire_date)=1981
	if exists( select e.emp_id from employee e where Year(hire_date)=1982)
	  select e.emp_id from employee e where Year(hire_date)=1992
	 else
	  select  null as emp_id
	  
	  
	  
----------------------------------------------------------------------------------------

--1-- 
select * from employee
update employee set lname='Drexler' where emp_id='VPA30890F'
select * from employee where emp_id='VPA30890F'


--2--
update  employee set job_id='14' where fname='paolo'

--3--
insert into employee values('HKJ34887F','Fyaa','M','aggg',13,54,'0877','11/24/1997')

----------------------------------------------------------------------------------------



--1--
select * from employee where (month(hire_date)<=3)

--2--
select e.fname,right(fname,3) as lastthreecharacters from employee e order by emp_id asc


select e.fname,SUBSTRING(fname,1,3) from employee e order by emp_id asc
--select emp_id,job_id from employee group by job_id,emp_id--

--3--
select fname,lEN(fname)as 'characters' from employee

select fname,replace(employee.fname,employee.fname,'*') as  'characters' from employee

select fname, replicate('*',Len(fname)) as  'characters' from employee


select fname,len(fname) as  'characters',stuff(fname,0,len(fname),'#') as 'NEW COl' from employee

--4--
select upper(fname) as newnames from employee


--5--

select *from roysched where len(hirange)=3

--6--
select * from roysched where (lorange%2)=1

select top 1 * from roysched order by hirange desc


----------------------------------------------------------------------------------------
--1--
select upper(substring(fname,2,len(fname))) as newstring from employee 

--2--
select* from titles

select *
from titles 
where advance>(select min(advance) from titles t join publishers p on t.pub_id=p.pub_id where pub_name='Algodata Infosystems')

select title from titles
select min(advance) from titles join publishers on  titles.pub_id=publishers.pub_id where pub_name='Algodata Infosystems'


--4--

select *
from titles 
where price>(select max(price) from titles where type='business')

select max(price) from titles where type='business'

--6--
select count(lorange) as coun,royalty
from roysched
group by royalty

--last character --substring(len-1,1)--


----------------------------------------------------------------------------------------


  
	  
	  
*/