# Selecciona la imagen base
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Establece el directorio de trabajo
WORKDIR /app

# Copia los archivos de proyecto y restaura las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia el resto de los archivos del proyecto y compila la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

# Selecciona una imagen base más ligera para la implementación
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expone el puerto necesario por tu aplicación
EXPOSE 80

# Establece el comando de inicio para tu aplicación
ENTRYPOINT ["dotnet", "api_net.dll"]
