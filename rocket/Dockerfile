FROM microsoft/dotnet:1.1-sdk
WORKDIR /app

# copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore
EXPOSE 5000

ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT dotnet run
#RUN dotnet publish -c Release -o out
#ENTRYPOINT ["dotnet", "out/rocket.dll"]