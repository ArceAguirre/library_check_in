/********************************************************************/
/*  Author      |   Arcelia Aguirre Treviño							*/
/*  Date        |   26-02-2018										*/
/*  Description	|   Consulta de Tipo de usuario			 			*/
/*  Name		|   type_user						 				*/
/*  Parameters	|   @id int not null								*/
/*					@description varchar(250)not null				*/
/*					@type_consult varchar(2) not null				*/
/*  Call		|   type_user @id = 0,								*/
/*					@description = '', @type_consult = ''			*/
/********************************************************************/
create procedure type_user_consult @id int, @description varchar(250), @type_consult varchar(2)
as
begin
    declare @LIST_L1 varchar(2)			= 'L1';
    declare @LIST_L2 varchar(2)			= 'L2';
    declare @CONSULT_L1 varchar(2)		= 'C1';
    declare @CONSTANT_LIKE varchar(1)	= '%';

    set @description = ltrim(rtrim(@description));

    if @type_consult = @LIST_L1 
	begin
        select id as id_typeUser, description as description_typeUser
        from type_user
        where active = 1;
        return;
    end 
    
    if @type_consult = @LIST_L2 
    begin
        select id as id_typeUser, description as description_typeUser
        from type_user
        where active = 1 and
            description like @CONSTANT_LIKE + @description + @CONSTANT_LIKE;
        return;
    end     
    
     if @type_consult = @CONSULT_L1
    begin
        select id, description
        from type_user
        where active = 1 and
            id = @id;
        return;
    end
end