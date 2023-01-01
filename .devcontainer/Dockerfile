# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:de85bc04e2c9357db69c109379439cb8ce5b91612307ea93d08c1fedd9dd4c22
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh