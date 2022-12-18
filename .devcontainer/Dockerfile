# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:2b691e4b24e186193e88dde57d1911db6c37109369e911d3322e23fbad5f25b4
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh