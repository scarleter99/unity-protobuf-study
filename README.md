# cs-mmorpg-game

![MMO 컨텐츠 구현](https://github.com/scarleter99/cs-mmorpg-game/assets/39542671/65e3fd16-e036-480e-baad-8feeefa93edf)

## 프로젝트 소개

2D Unity 프로젝트와 C# 서버를 연동하는 학습 프로젝트입니다.

## 프로젝트 목적

서버 연동을 고려한 Unity 프로젝트 개발 학습과 서버를 직접 구현하여 패킷 처리와 멀티 쓰레드 환경에 적응

## 사용 언어 및 개발 환경

- C#
- Unity Engine

## 프로젝트 특징

### Unity Engine

- 서버 연동을 고려한 GameObject Controller 설계
- 유한상태머신을 이용한 GameObject 상태 처리
- TileMap을 이용한 맵 설계
- 서버와의 패킷 교환 및 처리 구현

### C# Server

- 멀티플레이 환경 설계
  - 실시간 GameObject 데이터를 서버에서 관리 및 처리
  - 다수의 클라이언트와 서버와의 실시간 데이터 동기화
- A* 알고리즘을 이용한 몬스터 AI 설계
- 멀티쓰레드 환경에 적합한 Job 시스템 구현
- JSON 파일을 이용한 데이터 관리

## 링크

블로그: https://velog.io/@scarleter99/series/Unity-MMO-컨텐츠-구현
