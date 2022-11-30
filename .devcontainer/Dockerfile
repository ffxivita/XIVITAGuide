# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:14c2778e393d4274a4159084f72564c0c03b2a0d827a9707f11b7fcbafa482c9
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh