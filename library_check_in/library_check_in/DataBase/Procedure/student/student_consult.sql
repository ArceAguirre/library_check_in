/********************************************************************/
/*  Author      |   Arcelia Aguirre Treviño							*/
/*  Date        |   23-02-2018										*/
/*  Description	|   Consulta de Estudiantes		 					*/
/*  Name		|   student_consult				 					*/
/*  Parameters	|   @id int											*/
/*				|	@number varchar(7)								*/
/*				|	@student_name varchar(250)						*/
/*  Call		|   student_consult @id = 0,@number = '',			*/
/*				|	@student_name = '', @type_consult = ''			*/
/********************************************************************/
create procedure student_consult @id int,@number varchar(7), @student_name varchar(250), @type_consult varchar(2)
as
begin
    declare @LIST_L1 varchar(2)			= 'L1';
    declare @LIST_L2 varchar(2)			= 'L2';
    declare @CONSULT_L1 varchar(2)		= 'C1';
    declare @CONSTANT_LIKE varchar(1)	= '%';

    set @number = ltrim(rtrim(@number));
	set @student_name = ltrim(rtrim(@student_name));

    if @type_consult = @LIST_L1 
	begin
        select s.id as id_student, s.number, s.student_name, s.student_father_last_name, 
			s.student_mother_last_name, s.semester, s.id_career, c.career_name, c.career_key
        from student s
        inner join career c
			on c.id = s.id_career
        where s.active = 1;
        return;
    end 
    
    if @type_consult = @LIST_L2 
    begin
        select s.id as id_student, s.number, s.student_name, s.student_father_last_name, 
			s.student_mother_last_name, s.semester, s.id_career, c.career_name, c.career_key
        from student s
        inner join career c
			on c.id = s.id_career
        where s.active = 1 and
            s.student_name like @CONSTANT_LIKE + @student_name + @CONSTANT_LIKE;
        return;
    end     
    
     if @type_consult = @CONSULT_L1
    begin
        select s.id as id_student, s.number, s.student_name, s.student_father_last_name, 
			s.student_mother_last_name, s.semester, s.id_career, c.career_name, c.career_key
        from student s
        inner join career c
			on c.id = s.id_career
        where s.active = 1 and
            s.id = @id;
        return;
    end
end