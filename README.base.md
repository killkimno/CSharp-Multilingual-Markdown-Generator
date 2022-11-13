# CSharp-Multilingual-Markdown-Generator

<!--[document_link]-->
<!--[kr]-->
다국어 마크다운 문서 생성기

이 프로젝트는 ryul1206님의 multilingual-markdown 프로젝트를 기반으로 만들어 졌습니다.
<!--[en]-->
Multilingual Markdown Generator

This project is based on ryul1206's multilingual-markdown project.
<!--[common]-->

[Link : https://github.com/ryul1206/multilingual-markdown ](https://github.com/ryul1206/multilingual-markdown)

<!--[kr]-->
## 개요
코드 키워드를 이용해 각 언어별 문서를 생성해줍니다.
<!--[en]-->
## Overview
It creates documents for each language using code keywords.

<!--[kr]-->
## 사용법
<!--[en]-->
## How to Use
<!--[kr]-->
### 파일 규칙
<!--[en]-->
### File Rule
<!--[kr]-->
{FileName}.base.md 으로 되어 있어야 합니다. 예시는 [example.base.md](example/example.base.md)을 보시면 됩니다

ex : Readme.base.md
<!--[en]-->
It should be {FileName}.base.md . For an example, see this documnet [example.base.md](example/example.base.md)

ex : Readme.base.md

<!--[kr]-->
### 문서 생성
<!--[en]-->
### Generate Documnet
<!--[kr]-->
문서 생성 / Generate 버튼을 이용해 파일을 선택후 만듭니다
<!--[en]-->
Use '문서 생성 / Generate' button to select a file and create it

<!--[kr]-->
### 주 언어 설정
<!--[en]-->
### Select Main Language
<!--[kr]-->
주 언어 / Main Language 의 라디오 버튼을 이용해 주 언어를 설정합니다.
주 언어로 선택된 언어는 파일 이름에서 .base. 가 제거되어서 나옵니다

(ex :Readme.base.md -> Readme.md)
<!--[en]-->
Use '주 언어 / Main Language' radio button to set the primary language.
The language selected as the primary language is the .base. is removed and comes out

(ex :Readme.base.md -> Readme.md)


<!--[kr]-->
## 코드 키워드
<!--[en]-->
## Code Keyword
<!--[kr]-->
**언어 키워드**

<!--[en]-->
**Language Keyword**

<!--[kr]-->
언어별 텍스트 영역을 구분하는 키워드입니다.
언어 키워드를 인식한 후 다음 언어 키워드나 공통 영역 키워드를 만날때가지 해당 언어로 처리됩니다.

아래는 현재 지원하는 언어입니다
<!--[en]-->
A keyword that separates language-specific text areas.
After recognizing a language keyword, it is processed in that language until the next language keyword or common area keyword is encountered.

currently supported language list
<!--[common]-->
```
<!-- [en] -->        
<!-- [kr] -->
<!-- [fr] -->
<!-- [jp] -->
```

<!--[kr]-->
**공통 영역**

<!--[en]-->
**Common Area**

<!--[kr]-->
모든 언어에 공통으로 들어갈 텍스트 영역을 구분하는 키워드입니다.
<!--[en]-->
A keyword that delimits a text area common to all languages.

<!-- [common] -->
```
<!-- [common] -->   
```


<!--[kr]-->
**무시 영역**

<!--[en]-->
**Igonore Area**

<!--[kr]-->
주석용으로 쓰는 영역입니다. 이 영역에 지정된 텍스트는 파일에 포함되지 않습니다
<!--[en]-->
This area is used for comments. Text specified in this area will not be included in the file

<!-- [common] -->
```
<!-- [ignore] -->   
```


<!--[kr]-->
**언어 링크 키워드**

<!--[en]-->
**Language Link**


<!--[kr]-->
이 키워드가 있는 곳는 언어별 문서 링크 텍스트로 대체됩니다. 문서에 포함된 언어를 자동으로 링크해 줍니다
<!--[en]-->
Wherever this keyword appears, it will be replaced with the language-specific document link text. 
Automatically links to languages embedded in documents

<!-- [common] -->
```
<!-- [document_link] -->   
```









