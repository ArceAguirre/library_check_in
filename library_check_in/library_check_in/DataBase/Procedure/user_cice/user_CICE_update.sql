/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   20-02-2018										*/
/*  Description	|   Modificacion de Usuario			 				*/
/*  Name		|   user_CICE					 					*/
/*  Parameters	|   @id int											*/
/*					@user_name varchar(50)not null					*/
/*				|	@user_password varchar(50) not null				*/
/*				|	@father_last_name varchar(50) not null			*/
/*				|	@mother_last_name varchar(50)					*/
/*				|	@id_type_user int not null						*/
/*  Call		|   user_CICE__update @id = 0, @user_name = '',		*/
/*				|	@user_password = '', @father_last_name = '',	*/
/*				|	@mother_last_name = '', @id_type_user = 0		*/
/********************************************************************/
create procedure user_CICE_update @id int, @user_name varchar(7), @user_password varchar(50), @user_password_old varchar(50), @father_last_name varchar(50),
	@mother_last_name varchar(50), @id_type_user int
as
begin
	declare @var_id integer;
	declare @var_password varchar(50);
	declare @var_id_type_user int; 

	set @user_name = ltrim(rtrim(@user_name));
	set @var_password = ltrim(rtrim(@user_password));
	set @father_last_name = ltrim(rtrim(@father_last_name));
	set @id_type_user = ltrim(rtrim(@id_type_user));
	
	select @var_id_type_user = id from type_user where id = @id_type_user and active = 1;
	
	select @var_id = 1|id from student where id = @id and active = 1;
	
	
	if @user_name = '' or @user_name = null or @user_name is null
	begin
    	select 
            '001' as error,
            'El nombre está vacío' as error_message;
        return
	end
	if @father_last_name = null or @father_last_name is null or @father_last_name = ''
	begin
		select 
			'002' as error,
			'El apellido paterno está vacío' as error_message;
		return;
	end
	if @var_password = null or @var_password is null or @var_password = ''
	begin
		select 
			'003' as error,
			'La contraseña está vacía' as error_message;
		return;
	end
	if @var_id_type_user = '' or @var_id_type_user = null or @var_id_type_user is null or @var_id_type_user = 0
	begin
    	select 
            '004' as error,
            'No existe la Licenciatura' as error_message;
            return
	end
	
	update user_CICE set 
		user_name = @user_name, 
		/*user_password = @user_password,*/
		father_last_name = @father_last_name, 
		mother_last_name = @mother_last_name,
		id_type_user = @id_type_user, 
		updated_at = getdate()
	where id = @id;
	
	select 
		'000' as error,
		'Correcto' as error_message;
end;