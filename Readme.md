# 🎮 TextRPG - Console-Based RPG Game in C#

텍스트 기반의 콘솔 RPG 게임입니다.  
C# 언어와 .NET을 활용하여 `MVC 패턴` 기반으로 설계하였으며, 상점, 인벤토리, 플레이어 정보 관리 등의 기능을 제공합니다.

---

## 🧩 Features(구현된 기능)

- 플레이어 상태 보기  
- 인벤토리 확인 및 장착/해제 기능  
- 상점에서 아이템 구매  
- 휴식하기  

---

## ⚠️ To be updated(업데이트 예정)

- GitHub 오류로 인해 복구된 `Shop` 클래스 삭제 예정 (`ShopManager`가 동일 기능 담당)
- `UpdatePlayerStates`에서 `AttackPower`와 `Defense` 초기화를 `BaseAttackPower`, `BaseDefense`로 수정 예정
- 플레이어가 가진 아이템 리스트 별도 생성 예정

---

## 📁 프로젝트 구조

```
/ProjectRoot
│
├── Model/            ← 데이터, 로직
│   ├── BuyItemResult.cs
│   ├── Item.cs
│   └── Player.cs
│
├── View/             ← 입/출력 관련
│   └── UIManager.cs
│
├── Controller/       ← 게임 흐름, 입력 처리
│   └── GameManager.cs
|   ├── InventoryManager.cs
|   └── ShopManager.cs
│
├── Program.cs        ← 메인 진입점
└── Utils/            ← 공통 기능, 유틸 클래스 등
```