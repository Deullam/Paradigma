# Paradigma
Resolução do desafio da Paradigma

![image](https://user-images.githubusercontent.com/39167458/123905985-c243df00-d949-11eb-9fc6-5482574562bb.png)


#### Resposta: SELECT departamento.nome, pessoa.nome, salario FROM pessoa INNER JOIN departamento ON (DeptId = idDepartamento) WHERE salario IN (SELECT max(salario) FROM pessoa GROUP BY DeptId);

![image](https://user-images.githubusercontent.com/39167458/123906025-d25bbe80-d949-11eb-99f5-aa9476cac4cf.png)
