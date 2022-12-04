# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:280c5a93b696e08eef2601c1b55bc256c29441235cef31ecb9423ec28a2e41a3
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh