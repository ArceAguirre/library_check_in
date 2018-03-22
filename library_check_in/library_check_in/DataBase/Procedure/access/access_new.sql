/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   15-03-2018										*/
/*  Description	|   Alta de Ingreso a la biblioteca					*/
/*  Name		|   access_new				 						*/
/*  Parameters	|   @id_student varchar(7)							*/
/*					@id_not_student varchar(7)						*/
/*  Call		|   access_new @student_number ='',					*/
/*					@not_student_number	= ''						*/
/********************************************************************/
create procedure access_new @student_number varchar(7), @not_student_number varchar(7)
as
begin
	declare @var_student integer;
	declare @var_not_student integer;
	declare @var_last_insert_id datetime;
	
	select top 1 @var_student = id from student where number = @student_number and active = 1;
	select top 1 @var_not_student = id from not_student where number = @not_student_number and active = 1;
	
	if (@var_student = 0 or @var_student = null or @var_student is null) and
		(@var_not_student = 0 or @var_not_student = null or @var_not_student is null)
	begin
    	select 
            '001' as error,
            'No se enonctró el usuario' as error_message,
            @var_student,
            @not_student_number;
        return
	end
	else
		insert into access(id_student,id_not_student)
		values(@var_student, @var_not_student)
		
		select top 1 @var_last_insert_id = created_at from access order by id desc
		if @var_student != 0 or @var_student != null or @var_student is not null
		begin
			select 
				s.id , s.number, s.student_name, s.student_father_last_name,
				s.student_mother_last_name, s.semester, s.id_career, c.career_name,
				@var_last_insert_id as signInDate
			from student as s
			inner join career as c
				on c.id = s.id_career
			where s.id = @var_student
			return
		end
		
		if @var_not_student != 0 or @var_not_student != null or @var_not_student is not null
		begin
			select 
				ns.id,ns.number, ns.name, ns.father_last_name, ns.mother_last_name, ns.id_type_not_student,
				tns.description, @var_last_insert_id as signInDate
			from not_student ns
			inner join type_not_student tns
				on tns.id = ns.id_type_not_student
			where tns.id = @not_student_number
		end
end;