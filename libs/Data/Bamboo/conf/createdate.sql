select CONCAT('column ',t.table_name,'.create_date to "timestamp not null DEFAULT now()" drop default,')
from information_schema.tables t
inner join information_schema.columns c on c.table_name = t.table_name 
                                and c.table_schema = t.table_schema
where c.column_name = 'create_date'
      and t.table_schema not in ('information_schema', 'pg_catalog')
      and t.table_type = 'BASE TABLE'
order by t.table_name;
