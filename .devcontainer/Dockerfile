# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:f2700f00fd40e4fd69356b4c4ddd4f2b62a58ad612a98fc8be9e6e83799fdaf7
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh