/********************************************************************/
/*  Author      |   Arcelia Aguirre Treviño							*/
/*  Date        |   23-02-2018										*/
/*  Description	|   Consulta de Usuarios		 					*/
/*  Name		|   user_CICE_consult				 				*/
/*  Parameters	|   @id int											*/
/*				|	@student_name varchar(250)						*/
/*  Call		|   user_CICE_consult @id = 0,						*/
/*				|	@user_name = '', @type_consult = ''				*/
/********************************************************************/
create procedure user_CICE_consult @id int, @user_name varchar(250), @type_consult varchar(2)
as
begin
    declare @LIST_L1 varchar(2)			= 'L1';
    declare @LIST_L2 varchar(2)			= 'L2';
    declare @CONSULT_L1 varchar(2)		= 'C1';
    declare @CONSTANT_LIKE varchar(1)	= '%';

	set @user_name = ltrim(rtrim(@user_name));

    if @type_consult = @LIST_L1 
	begin
        select uc.id as id_user, uc.user_name as name_user, uc.father_last_name as fatherLastName_user, 
			uc.mother_last_name as motherLastName_user, uc.id_type_user , tu.description as description_user
        from user_CICE uc
        inner join type_user tu
			on tu.id = uc.id_type_user
        where uc.active = 1;
        return;
    end 
    
    if @type_consult = @LIST_L2 
    begin
       select uc.id as id_user, uc.user_name as name_user, uc.father_last_name as fatherLastName_user, 
			uc.mother_last_name as motherLastName_user, uc.id_type_user , tu.description as description_user
        from user_CICE uc
        inner join type_user tu
			on tu.id = uc.id_type_user
        where uc.active = 1 and
            uc.user_name like @CONSTANT_LIKE + @user_name + @CONSTANT_LIKE;
        return;
    end     
    
     if @type_consult = @CONSULT_L1
    begin
        select uc.id as id_user, uc.user_name, uc.father_last_name, 
			uc.mother_last_name, uc.id_type_user, tu.description
        from user_CICE uc
        inner join type_user tu
			on tu.id = uc.id_type_user
        where uc.active = 1 and
            uc.id = @id;
        return;
    end
end