@echo off
docker stop sqlservertoasp
docker rm -f sqlservertoasp
docker run --name sqlservertoasp -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=DockerSql2017!" -e "MSSQL_PID=Developer" --cap-add SYS_PTRACE -p 1433:1433 -v C:\SQLServer2017:/var/opt/mssql -d microsoft/mssql-server-linux:latest
docker cp sql.sql sqlservertoasp:sql.sql
docker exec -it sqlservertoasp /opt/mssql-tools/bin/sqlcmd -U "sa" -P "DockerSql2017!" -i "sql.sql" -l 65534 -t 65534
echo "SQLServer2017 - On"

docker stop aspnetcore
docker rm -f aspnetcore
docker build -t aspnet/comeia:latest .
docker run --rm -p 80:80 --name aspnetcore -d aspnet/comeia:latest
echo "Asp.net Core - On"