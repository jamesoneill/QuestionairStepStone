#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app
EXPOSE 80
RUN apk add bash icu-libs krb5-libs libgcc libintl libssl1.1 libstdc++ zlib tzdata

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JO.QuestionnaireStepStone.WebAPI/JO.QuestionnaireStepStone.WebAPI.csproj", "JO.QuestionnaireStepStone.WebAPI/"]
RUN dotnet restore "JO.QuestionnaireStepStone.WebAPI/JO.QuestionnaireStepStone.WebAPI.csproj"
COPY . .
WORKDIR "/src/JO.QuestionnaireStepStone.WebAPI"
RUN dotnet build "JO.QuestionnaireStepStone.WebAPI.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "JO.QuestionnaireStepStone.WebAPI.csproj" -c Release -o /app/publish


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JO.QuestionnaireStepStone.WebAPI.dll"]