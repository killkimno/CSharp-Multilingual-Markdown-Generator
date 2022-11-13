# CSharp-Multilingual-Markdown-Generator

🌏[한국어](README.kr.md) | [English](README.en.md)


다국어 마크다운 문서 생성기

이 프로젝트는 ryul1206님의 multilingual-markdown 프로젝트를 기반으로 만들어졌습니다.

[Link : https://github.com/ryul1206/multilingual-markdown ](https://github.com/ryul1206/multilingual-markdown)

## 개요
코드 키워드를 이용해 각 언어별 문서를 생성해줍니다.
## 사용법
### 파일 규칙
{FileName}.base.md 으로 되어 있어야 합니다. 예시는 [example.base.md](example/example.base.md)을 보시면 됩니다

ex : Readme.base.md
### 문서 생성
문서 생성 / Generate 버튼을 이용해 파일을 선택 후 만듭니다
### 주 언어 설정
주 언어 / Main Language 의 라디오 버튼을 이용해 주 언어를 설정합니다.
주 언어로 선택된 언어는 파일 이름에서 .base. 가 제거되어서 나옵니다

(ex :Readme.base.md -> Readme.md)
## 코드 키워드
**언어 키워드**

언어별 텍스트 영역을 구분하는 키워드입니다.
언어 키워드를 인식한 후 다음 언어 키워드나 공통 영역 키워드를 만날때가지 해당 언어로 처리됩니다.

아래는 현재 지원하는 언어입니다
```
<!-- [en] -->        
<!-- [kr] -->
<!-- [fr] -->
<!-- [jp] -->
```

**공통 영역**

모든 언어에 공통으로 들어갈 텍스트 영역을 구분하는 키워드입니다.
```
<!-- [common] -->   
```


**무시 영역**

주석용으로 쓰는 영역입니다. 이 영역에 지정된 텍스트는 파일에 포함되지 않습니다
```
<!-- [ignore] -->   
```


**언어 링크 키워드**

이 키워드가 있는 곳은 언어별 문서 링크 텍스트로 대체됩니다. 문서에 포함된 언어를 자동으로 링크해 줍니다
```
<!-- [document_link] -->   
```









