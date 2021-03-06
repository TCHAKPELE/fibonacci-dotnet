﻿FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish ".\src\Fibonacci.Web.csproj" -c Release -r linux-x64 /p:PublishSingleFile=true -o /publish

FROM mcr.microsoft.com/dotnet/runtime-deps:5.0 AS final
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["/app/Fibonacci.Web"]