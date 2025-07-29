select e.first_name,d.department_name from employees e join departments d using(department_id);

select e.first_name,l.city from employees e join departments d using(department_id) join locations l using(location_id);

select * from user_tables;
select * from user_tab_columns where table_name='EMPLOYEES';
select * from user_constraints where table_name='EMPLOYEES';
select * from user_cons_columns where constraint_name='EMP_DEPT_FK';

create view emp_dept as select e.first_name,d.department_name from employees e join departments d using(department_id);
select * from emp_dept;

select first_name from employees where department_id=(select department_id from departments where department_name='Sales');

create index emp_lastname_idx on employees(last_name);

create sequence emp_seq start with 1000 increment by 1;

select last_name,case department_id when 10 then 'admin' when 20 then 'sales' else 'other' end as dept_type from employees;

select last_name,decode(department_id,10,'admin',20,'sales','other') as dept_type from employees;

            select to_char(sysdate,'dd-mm-yyyy') from dual;
            select to_char(hire_date,'yyyy/mm/dd hh24:mi') from employees;
            select to_char(hire_date,'month     dd, yyyy') from employees;

insert into departments(department_id,department_name) values(300,'dev');
update employees set salary=salary*1.1 where department_id=90;
delete from departments where department_id=300;

with high_paid as (select * from employees where salary>10000) select first_name from high_paid;

merge into employees e using (select 100 employee_id,'john' first_name from dual) new_emp on(e.employee_id=new_emp.employee_id) when matched then update set e.first_name=new_emp.first_name when not matched then insert(employee_id,first_name) values(new_emp.employee_id,new_emp.first_name);

select upper(first_name),length(last_name),nvl(commission_pct,0) from employees;

select * from user_tables;
select * from user_tab_columns;
select * from user_constraints;
select * from user_cons_columns;
select * from all_objects;
select * from all_tab_privs;
select * from user_views;
select * from user_sequences;
select * from user_indexes;
select * from user_ind_columns;

select utc.table_name, utc.column_name, utc.data_type 
from user_tab_columns utc join user_tables ut using(table_name);

select uc.constraint_name, ucc.column_name 
from user_constraints uc join user_cons_columns ucc using(constraint_name);

select ui.table_name, ui.index_name, uic.column_name 
from user_indexes ui join user_ind_columns uic using(index_name);

select sequence_name, last_number from user_sequences;

select * from all_tab_privs where grantee=user;

select view_name, text from user_views;

select object_name, object_type from all_objects where owner='HR';
