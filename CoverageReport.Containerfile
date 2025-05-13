FROM mcr.microsoft.com/dotnet/sdk:8.0

RUN dotnet tool install --global dotnet-reportgenerator-globaltool
ENV PATH="${PATH}:/root/.dotnet/tools"

WORKDIR /app

COPY . .

RUN dotnet restore qs.geometry.sln

CMD ["/bin/bash", "-c", "dotnet test qs.geometry.sln --collect:\"XPlat Code Coverage\" --results-directory /app/TestResults --logger:\"trx\" && reportgenerator \"-reports:/app/TestResults/**/*.cobertura.xml\" \"-targetdir:/app/CoverageReport\" \"-reporttypes:Html\""]
