FROM microsoft/dotnet:sdk
RUN ls
# Create app directory
RUN mkdir -p /usr/app
WORKDIR /usr/app

# Bundle app source
COPY ./publish /usr/app

RUN ls /usr/app
RUN dotnet net-core-halloworld