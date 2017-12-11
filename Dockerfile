FROM microsoft/dotnet:sdk

# Create app directory
RUN mkdir -p /usr/app
WORKDIR /usr/app

# Bundle app source
COPY ./publish /usr/app

RUN dotnet net-core-halloworld.dll

EXPOSE 5000