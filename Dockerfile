# Define a imagem base para a etapa "base", usando o SDK do ASP.NET Core 7.0
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base

# Define o diretório de trabalho dentro do contêiner
WORKDIR /app

# Expõe a porta 80 para HTTP e a porta 443 para HTTPS
EXPOSE 80
EXPOSE 443

# Define uma nova etapa de build, baseada no SDK do .NET Core 7.0
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Define o diretório de trabalho para a etapa de build como /src
WORKDIR /src

# Copia o arquivo de projeto .csproj para o diretório /src/SistemaControleLuminosidade/
COPY ["SistemaControleLuminosidade/SistemaControleLuminosidade.csproj", "SistemaControleLuminosidade/"]

# Restaura as dependências do projeto .csproj
RUN dotnet restore "SistemaControleLuminosidade/SistemaControleLuminosidade.csproj"

# Copia todo o conteúdo do contexto atual para o diretório /src/ dentro do contêiner
COPY . .

# Define o diretório de trabalho para a aplicação específica dentro de /src/
WORKDIR "/src/SistemaControleLuminosidade"

# Compila o projeto .NET usando o perfil de configuração Release e gera a saída em /app/build
RUN dotnet build "SistemaControleLuminosidade.csproj" -c Release -o /app/build

# Define uma nova etapa de build, baseada na etapa "build" anterior
FROM build AS publish

# Publica o projeto .NET usando o perfil de configuração Release e gera a saída em /app/publish
RUN dotnet publish "SistemaControleLuminosidade.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Define uma nova etapa baseada na etapa "base", para criar a imagem final do contêiner
FROM base AS final

# Define o diretório de trabalho para a etapa final como /app
WORKDIR /app

# Copia o conteúdo do diretório de publicação da etapa "publish" para o diretório /app da etapa final
COPY --from=publish /app/publish .

# Define o ponto de entrada padrão para o contêiner
ENTRYPOINT ["dotnet", "SistemaControleLuminosidade.dll"]