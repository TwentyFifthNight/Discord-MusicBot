# Discord Music Bot – CSharp

## Overview
 Music Bot for Discord using DSharpPlus, Lavalink4NET and Lavalink

## Requirements
 * .NET 8.0 runtime
 * [JDK 17.0.2](https://jdk.java.net/archive/)
 * [Lavalink 4.0.8](https://github.com/lavalink-devs/Lavalink/releases)
   

## Configuration
 1. To set up Lavalink, follow the instructions from the official [Lavalink website](https://lavalink.dev/getting-started/index.html).
 2. Go to the [Discord Developer page](https://discord.com/developers/applications/) and create a new app. Go to the Bot tab and press Reset Token button. Press the Copy button and save the token for later.
 3. Download the contents of this repository.
 4. Rename example.appsettings.json to appsettings.json and paste your discord token into the token field. Configure the remaining fields in the appsettiings.json file. Their values should be in the corresponding fields in the Lavalink configuration file.
 5. Build Bot application using Visual Studio or Command Prompt.
 6. Run Lavalink.
 7. Run the Bot application.

## Inviting Bot to your Discord server
 To invite bot go to the [Discord Developer page](https://discord.com/developers/applications/), select your bot and  go to the OAuth2 tab. Scroll down and check the **applications.commands** and **bot** checkboxes. Bot permissions should have appeard. Check **Read Messages/View Channels**, **Send Messages**, **Manage Messages**, **Embed Links**, **Read Message History**, **Add Reactions**, **Connect** and **Speak** permissons checkboxes. Copy generated URL and paste it into your browser. Choose server and click **Authorize** button.

## Lavalink Settings
<!--
> [!IMPORTANT]
> For now, the latest youtube plugin (1.13.0) for Lavalink does not work. The fix is already merged into the youtube-source repository, so until the new version is available, you can fork the [youtube-source repository](https://github.com/lavalink-devs/youtube-source) and build the plugin yourself. After placing the new .jar file in the Lavalink plugins folder, comment out the plugin in the application.yml file, otherwise it will overwrite your file.
```
lavalink:
  plugins:
    #- dependency: "dev.lavalink.youtube:youtube-plugin:1.13.0"
    #  snapshot: false
```
-->

> [!IMPORTANT]   
> You will most likely have to use OAuth Tokens to make the bot work. With the updated contents of the application.yml file below, you should be asked by Lavalink to give youtube-source access to your account at Lavalink startup. Correct authorization should result in your token being displayed in a terminal running Lavalink. You can copy the obtained token into the application.yml file as the value of the "refreshToken" key and uncomment it by removing the "#" symbol. Using your main account for authorization is not recommended. For more information visit [link](https://github.com/lavalink-devs/youtube-source?tab=readme-ov-file#using-oauth-tokens).

 An example application.yml file can be found at this [link](https://github.com/lavalink-devs/Lavalink/blob/master/LavalinkServer/application.yml.example/). You can also copy my application.yml options. Remember to change the **port**, **address** and **password** to match the values in the **appsettings.json file**. 
 
```
server:
  port: 2333
  address: 0.0.0.0
  http2:
    enabled: false
plugins:
  youtube:
    enabled: true
    allowSearch: true
    allowDirectVideoIds: true
    allowDirectPlaylistIds: true
    clients: 
      - MUSIC
      - ANDROID_VR
      - TVHTML5EMBEDDED
    oauth:
      enabled: true
    #  refreshToken: "your token"
lavalink:
  plugins:
    - dependency: "dev.lavalink.youtube:youtube-plugin:1.13.2"
      snapshot: false
  server:
    password: "youshallnotpass"
    sources:
      youtube: false
      bandcamp: false
      soundcloud: false
      twitch: false
      vimeo: false
      nico: false
      http: false
      local: false
    filters:
      volume: true
      equalizer: true
      karaoke: true
      timescale: true
      tremolo: true
      vibrato: true
      distortion: true
      rotation: true
      channelMix: true
      lowPass: true
    bufferDurationMs: 1200
    frameBufferDurationMs: 10000
    opusEncodingQuality: 8
    resamplingQuality: LOW
    trackStuckThresholdMs: 10000
    useSeekGhosting: true
    youtubePlaylistLoadLimit: 6
    playerUpdateInterval: 5
    youtubeSearchEnabled: true
    soundcloudSearchEnabled: true
    gc-warnings: true
metrics:
  prometheus:
    enabled: false
    endpoint: /metrics

sentry:
  dsn: ""
  environment: ""

logging:
  file:
    path: ./logs/

  level:
    root: INFO
    lavalink: INFO
    dev.lavalink.youtube.http.YoutubeOauth2Handler: INFO
  request:
    enabled: true
    includeClientInfo: true
    includeHeaders: false
    includeQueryString: true
    includePayload: true
    maxPayloadLength: 10000


  logback:
    rollingpolicy:
      max-file-size: 1GB
      max-history: 30
```
