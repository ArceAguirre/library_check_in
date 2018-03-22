/********************************************************************/
/*  Author      |   Arcelia Aguirre Treviño							*/
/*  Date        |   23-02-2018										*/
/*  Description	|   Consulta de No Estudiantes		 				*/
/*  Name		|   not_student_consult				 				*/
/*  Parameters	|   @id int											*/
/*				|	@number varchar(7)								*/
/*				|	@not_student_name varchar(250)					*/
/*  Call		|   not_student_consult @id = 0,@number = '',		*/
/*				|	@not_student_name = '', @type_not_student = 0,	*/
/*				|	@type_consult = ''								*/
/********************************************************************/
create procedure not_student_consult @id int,@number varchar(7), @not_student_name varchar(250), @type_not_student int, @type_consult varchar(2)
as
begin
    declare @LIST_L1 varchar(2)			= 'L1';
    declare @LIST_L2 varchar(2)			= 'L2';
    declare @LIST_L3 varchar(2)			= 'L3';
    declare @CONSULT_L1 varchar(2)		= 'C1';
    declare @CONSTANT_LIKE varchar(1)	= '%';

    set @number = ltrim(rtrim(@number));
	set @not_student_name = ltrim(rtrim(@not_student_name));

    if @type_consult = @LIST_L1 
	begin
        select ns.id as id_student, ns.number, ns.name, ns.father_last_name, 
			ns.mother_last_name, ns.id_type_not_student, tns.description
        from not_student ns
        inner join type_not_student tns
			on tns.id = ns.id_type_not_student
        where ns.active = 1;
        return;
    end 
    
    if @type_consult = @LIST_L2 
    begin
        select ns.id as id_student, ns.number, ns.name, ns.father_last_name, 
			ns.mother_last_name, ns.id_type_not_student, tns.description
        from not_student ns
        inner join type_not_student tns
			on tns.id = ns.id_type_not_student
        where ns.active = 1 and
            ns.name like @CONSTANT_LIKE + @not_student_name + @CONSTANT_LIKE;
        return;
    end     
    
    if @type_consult = @LIST_L3
    begin
        select ns.id as id_student, ns.number, ns.name, ns.father_last_name, 
			ns.mother_last_name, ns.id_type_not_student, tns.description
        from not_student ns
        inner join type_not_student tns
			on tns.id = ns.id_type_not_student
        where ns.active = 1 and
            ns.id_type_not_student = @type_not_student
        return;
    end 
    
    
    if @type_consult = @CONSULT_L1
    begin
        select ns.id as id_student, ns.number, ns.name, ns.father_last_name, 
			ns.mother_last_name, ns.id_type_not_student, tns.description
        from not_student ns
        inner join type_not_student tns
			on tns.id = ns.id_type_not_student
        where ns.active = 1 and
            ns.id = @id;
        return;
    end
end