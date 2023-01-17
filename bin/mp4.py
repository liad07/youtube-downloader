import youtube_dl
import os
import webbrowser
import sys, os
sys.path.append('venv/Scripts')
y=""
def run(url):
    video_url = (url)
    video_info = youtube_dl.YoutubeDL().extract_info(
        url = video_url,download=False
    )
    y = f"{video_info['title']}.mp4"
    filename = f"{video_info['title']}.mp4"
    options = {
        'format': 'bestvideo/best',
        'keepvideo': True,
        'outtmpl': "output\\ video\\" + filename,
    }

    with youtube_dl.YoutubeDL(options) as ydl:
        ydl.download([video_info['webpage_url']])

    print("Download complete... {}".format(filename))
video=open("video.txt","r",encoding="utf8")
x=video.read()
print(x)
run(x)
video.close()
os.remove("video.txt")
webbrowser.open("output\\"+y)
