using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using Newtonsoft.Json;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project;

public static class Consts2
{
	public static CustomConst strichkaOtsynkovana05 = new CustomConst("Стрічка ОЦ 0.5 (В=137), м2", 43.331154188862, "Стрічка рулон оцинк 0,5х137", "12736KP1", "Стрічка рулон оцинк 0,5х137 кг", "TEZ0253", "м2", "кг");

	public static CustomConst strichkaOtsynkovana065 = new CustomConst("Стрічка ОЦ 0.65 (В=137), м2", 42.8, "Стрічка рулон оцинк 0,68х137", "89972KP1", "Стрічка рулон оцинк 0,65х137", "TEZ0255", "м2", "кг");

	public static CustomConst strichkaOtsynkovana068 = new CustomConst("Стрічка ОЦ 0.68 (В=137), м2", 42.8, "Стрічка рулон оцинк 0,68х137", "89972KP1", "Стрічка рулон оцинк 0,65х137", "TEZ0255", "м2", "кг");

	public static CustomConst strichkaOtsynkovana07 = new CustomConst("Стрічка ОЦ 0.7 (В=137), м2", 42.8, "Стрічка рулон оцинк 0,68х137", "89972KP1", "Стрічка рулон оцинк 0,7х137", "TEZ0257", "м2", "кг");

	public static CustomConst strichkaOtsynkovana09 = new CustomConst("Стрічка ОЦ 0.9 (В=137), м2", 44.8, "Стрічка рулон оцинк 0,9х137", "36288KP1", "Стрічка рулон оцинк 0,9х137", "TEZ0258", "м2", "кг");

	public static CustomConst strichkaOtsynkovana10 = new CustomConst("Стрічка ОЦ 1.0 (В=137), м2", 44.8, "Стрічка рулон оцинк 0,9х137", "36288KP1", "Стрічка рулон оцинк 0,9х137", "TEZ0258", "м2", "кг");

	public static CustomConst lystOchynkovanyj05 = new CustomConst("Рулон ОЦ 0.5, м2", 157.2718, "Лист оцинкований 0,48 (м.кв.)", "62826KP1", "Рулон оцинкований 0.5х1000х2000кг", "TEZ0182", "м2", "кг");

	public static CustomConst lystOchynkovanyj05_1 = new CustomConst("Рулон ОЦ 0.5, м2", 148.774215, "Лист оцинкований 0,5 (м.кв.)", "31384KP1", "Рулон оцинкований 0.5х1000х2000кг", "TEZ0182", "м2", "кг");

	public static CustomConst lystOchynkovanyj065 = new CustomConst("Рулон ОЦ 0.65, м2", 206.0276679, "Лист оцинкований 0.68 (м.кв.)", "84034KP1", "Рулон оцинкований 0.65х1250 кг", "TEZ0253", "м2", "кг");

	public static CustomConst lystOchynkovanyj068 = new CustomConst("Рулон ОЦ 0.68, м2", 206.0276679, "Лист оцинкований 0.68 (м.кв.)", "84034KP1", "Рулон оцинкований 0.68х1250", "TEZ025", "м2", "кг");

	public static CustomConst lystOchynkovanyj07 = new CustomConst("Рулон ОЦ 0.7, м2", 209.4166225, "Лист оцинкований 0.68 (м.кв.)", "84034KP1", "Рулон оцинкований 0.7х1250", "TEZ0255", "м2", "кг");

	public static CustomConst lystOchynkovanyj07_1 = new CustomConst("Рулон ОЦ 0.7, м2", 209.4166225, "Лист оцинкований 0.7 (м.кв.)", "32253KP1 ", "Рулон оцинкований 0.7х1250", "TEZ0255", "м2", "кг");

	public static CustomConst lystOchynkovanyj09 = new CustomConst("Рулон ОЦ 0.9, м2", 269.4925743, "Лист оцинкований 0.9 (м.кв.)", "32049KP1", "Рулон оцинкований 0.9х1250 кг", "TEZ0256", "м2", "кг");

	public static CustomConst lystOchynkovanyj10 = new CustomConst("Рулон ОЦ 1.0, м2", 351.6, "Лист оцинкований 0.9 (м.кв.)", "32049KP1", "Рулон оцинкований 1 (1,25)", "TEZ0257", "м2", "кг");

	public static CustomConst lystOchynkovanyj12 = new CustomConst("Рулон ОЦ 1.2, м2", 439.5, "Лист оцинкований 1,2 (м.кв.)", "46199KP1", "Рулон оцинкований 1.2х1250", "TEZ0120", "м2", "кг");

	public static CustomConst lystOchynkovanyj15 = new CustomConst("Рулон ОЦ 1.5, м2", 549.6533333, "Лист оцинкований 1,5 (м.кв.)", "65459KP1", "Рулон оцинкований 1.5х1250 кг", "TEZ0122", "м2", "кг");

	public static CustomConst lystStalnyj05 = new CustomConst("Лист СТ 0.5, м2", 277.85, "", "???", "Лист ст 0,5 1,0х2,0 м.кв.", "TEZ0314", "м2", "кг");

	public static CustomConst lystStalnyj08 = new CustomConst("Лист СТ 0.8, м2", 277.85, "", "???", "Лист ст х/к 0.8 1,0х2,0 м.кв.", "TEZ0366", "м2", "кг");

	public static CustomConst lystStalnyj10 = new CustomConst("Лист СТ 1.0, м2", 316.2, "", "???", "Лист ст х/к 1,0мм 1,0х2,0, м.кв", "TEZ0368", "м2", "кг");

	public static CustomConst lystStalnyj12 = new CustomConst("Лист СТ 1.2, м2", 409.0, "Лист ст х/к 1,2мм 1,25х2,5, м.кв", "35144KP1", "Лист ст х/к 1,2мм 1,0х2,0, м.кв", "TEZ0370", "м2", "кг");

	public static CustomConst lystStalnyj15 = new CustomConst("Лист ст3 1.5мм, м2", 509.3, "Лист ст х/к 1,5мм 1,25х2,5, м.кв", "28902KP1", "Лист ст х/к 1,5мм 1,0х2,0, м.кв", "TEZ0194", "м2", "кг");

	public static CustomConst lystStalnyj20 = new CustomConst("Лист Ст3  2мм, м2", 564.5, "Лист ст г/к 2мм 1,25х2,5, м.кв", "30399KP1", "Лист ст х/к 2мм 1,25х2,5, м.кв", "TEZ0376", "м2", "кг");

	public static CustomConst lystStalnyj25 = new CustomConst("Лист СТ 2.5, м2", 703.06528, "", "???", "Лист ст х/к 2мм 1,25х2,5, м.кв", "TEZ0375", "м2", "кг");

	public static CustomConst lystStalnyj30 = new CustomConst("Лист Ст 3  3, м2", 812.5, "Лист ст г/к 3мм 1,25х2,5, м.кв", "16679KP1", "Лист ст х/к 3,0мм 1,25х2,5, м.кв", "TEZ0377", "м2", "кг");

	public static CustomConst lystStalnyj40 = new CustomConst("Лист СТ 4.0, м2", 1213.76, "Лист ст 4мм 1,25х2,5", "34825KP1", "Лист ст г/к 4мм 1,250х2,500 м.кв", "TEZ0188", "м2", "кг");

	public static CustomConst lystNerzavijuchyj05 = new CustomConst("Лист нерж. AISI 430 0.5мм, м2", 315.779889939951, "Лист нерж AISI 430 0.5х1000х2000 4N+lass", "71864KP1", "Лист нерж AISI 430 0.5х1000х2000 2В", "TEZ0199", "м2", "кг");

	public static CustomConst lystNerzavijuchyj08 = new CustomConst("Лист нерж. AISI 430 0.8мм, м2", 545.28, "Лист нерж AISI 430 0.8х1000х2000 ВА PVC", "44668KP1", "Лист нерж AISI 430 0.8х1000х2000", "TEZ0169", "м2", "кг");

	public static CustomConst lystNerzavijuchyj10 = new CustomConst("Лист нерж. AISI 430 1мм, м2", 576.0, "Лист нерж AISI 430 1.0х1250х2500 4N+lass", "101696KP1", "Лист нерж AISI 430 1,0х1000х2000", "TEZ0170", "м2", "кг");

	public static CustomConst lystNerzavijuchyj12 = new CustomConst("Лист нерж. AISI 430 1.2мм, м2", 768.42625, "Лист нерж AISI 304 1.2х1000х2000 2В", "667518", "Лист нерж AISI 430 1,2х1000х2000 2В", "TEZ0171", "м2", "кг");

	public static CustomConst lystNerzavijuchyj15 = new CustomConst("Лист нерж. AISI 430 1.5мм, м2", 768.42625, "Лист нерж AISI 430 1.5х1.0х2.0 2В", "69067KP1", "Лист нерж AISI 430 1,5х1000х2000 2B", "TEZ0181", "м2", "кг");

	public static CustomConst lystNerzavijuchyj05_321 = new CustomConst("Лист нерж. AISI 321 0.5мм, м2", 960.0, "Лист нерж AISI 321 0.5х1000х2000 2В", "", "Лист нерж AISI 321 0,5х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj08_321 = new CustomConst("Лист нерж. AISI 321 0.8мм, м2", 1880.0, "Лист нерж AISI 321 0.8х1000х2000 2В", "", "Лист нерж AISI 321 0,8х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj10_321 = new CustomConst("Лист нерж. AISI 321 1мм, м2", 0.0, "Лист нерж AISI 321 1.0х1000х2000 2В", "30760KP1", "Лист нерж AISI 321 1,0х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj12_321 = new CustomConst("Лист нерж. AISI 321 1.2мм, м2", 0.0, "Лист нерж AISI 321 1.2х1000х2000 2В", "", "Лист нерж AISI 321 1,2х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj15_321 = new CustomConst("Лист нерж. AISI 321 1.5мм, м2", 0.0, "Лист нерж AISI 321 1.5х1.0х2.0 2В", "", "Лист нерж AISI 321 1,5х1000х2000 2B", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj05_316 = new CustomConst("Лист нерж. AISI 316 0.5мм, м2", 1302.0, "Лист нерж AISI 316 0.5х1000х2000 2В", "121790KP1", "Лист нерж AISI 316 0,5х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj08_316 = new CustomConst("Лист нерж. AISI 316 0.8мм, м2", 1680.0, "Лист нерж AISI 316 0.8х1000х2000 2В", "", "Лист нерж AISI 316 0,8х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj10_316 = new CustomConst("Лист нерж. AISI 316 1мм, м2", 0.0, "Лист нерж AISI 316 1.0х1000х2000 2В", "", "Лист нерж AISI 316 1,0х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj12_316 = new CustomConst("Лист нерж. AISI 316 1.2мм, м2", 0.0, "Лист нерж AISI 316 1.2х1000х2000 2В", "", "Лист нерж AISI 316 1,2х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj15_316 = new CustomConst("Лист нерж. AISI 316 1.5мм, м2", 0.0, "Лист нерж AISI 316 1.5х1.0х2.0 2В", "", "Лист нерж AISI 316 1,5х1000х2000 2B", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj05_304 = new CustomConst("Лист нерж. AISI 304 0.5мм, м2", 691.470010848902, "Лист нерж AISI 304 0.5х1000х2000 4N+lass", "86388KP1", "Лист нерж 304 0,5х1250х2500 РЕ", "TEZ0174", "м2", "кг");

	public static CustomConst lystNerzavijuchyj08_304 = new CustomConst("Лист нерж. AISI 304 0.8мм, м2", 664.850980392157, "Лист нерж AISI 304 0.6х1000х2000 2В", "81329KP1", "Лист нерж AISI 304 0,8х1250х2500  4N+laser pvc", "TEZ0178", "м2", "кг");

	public static CustomConst lystNerzavijuchyj10_304 = new CustomConst("Лист нерж. AISI 304 1мм, м2", 1360.5043413458, "Лист нерж AISI 304 1,0х1250х2500 №4 PE", "88946KP1", "Лист нерж 304 1,0х1000х2000  2B", "TEZ0175", "м2", "кг");

	public static CustomConst lystNerzavijuchyj12_304 = new CustomConst("Лист нерж. AISI 304 1.2мм, м2", 0.0, "Лист нерж AISI 304 1.2х1000х2000 2В", "", "Лист нерж AISI 304 1,2х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj15_304 = new CustomConst("Лист нерж. AISI 304 1.5мм, м2", 0.0, "Лист нерж AISI 304 1.5х1.0х2.0 2В", "", "Лист нерж AISI 304 1,5х1000х2000 2B", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj20_304 = new CustomConst("Лист нерж. AISI 304 2.0мм, м2", 2496.0, "Лист нерж AISI 304 2.0х1000х2000", "46090KP1", "Лист нерж AISI 304 1,5х1000х2000 2B", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj05_201 = new CustomConst("Лист нерж. AISI 201 0.5мм, м2", 308.208, "Лист нерж AISI 201 0.5х1000х2000 4N+lass", "71864KP1", "Лист нерж 201 0.5х1,0х2,0 4N+PVC ", "TEZ0199", "м2", "кг");

	public static CustomConst lystNerzavijuchyj08_201 = new CustomConst("Лист нерж. AISI 201 0.8мм, м2", 422.4, "Лист нерж AISI 201 0.8х1000х2000 ВА PVC", "666635", "Лист нерж AISI 201 0.8х1000х2000", "TEZ0169", "м2", "кг");

	public static CustomConst lystNerzavijuchyj10_201 = new CustomConst("Лист нерж. AISI 201 1мм, м2", 862.2304, "Лист нерж AISI 201 1,0х1240х2500 4N+ PVC", "114921KP1", "Лист нерж AISI 201 1,0х1240х25004N+ pvc ", "TEZ0705", "м2", "кг");

	public static CustomConst lystNerzavijuchyj12_201 = new CustomConst("Лист нерж. AISI 201 1.2мм, м2", 0.0, "Лист нерж AISI 201 1.2х1000х2000 2В", "", "Лист нерж AISI 201 1,2х1000х2000 2В", "", "м2", "кг");

	public static CustomConst lystNerzavijuchyj15_201 = new CustomConst("Лист нерж. AISI 201 1.5мм, м2", 0.0, "Лист нерж AISI 201 1.5х1.0х2.0 2В", "", "Лист нерж AISI 201 1,5х1000х2000 2B", "", "м2", "кг");

	public static CustomConst kutnyk25_25_4 = new CustomConst("Кутник 25х25х3, м.п.", 39.4039713904649, "Кутник ст 25х25х3", "45705KP1", "Кутник ст 25х25х3", "TEZ0153", "м", "");

	public static CustomConst kutnyk32_32_3 = new CustomConst("Кутник 32х32х3, м.п.", 41.45, "Кутник ст 32х32х3", "56445KP1", "Кутник ст 32х32х3", "TEZ0155", "м", "");

	public static CustomConst kutnyk35_35_4 = new CustomConst("Кутник 35х35х3, м.п.", 42.1, "Кутник ст 35х35х3", "34387KP1", "Кутник ст 35х35х3", "TEZ0156", "м", "");

	public static CustomConst kutnyk40_40_3 = new CustomConst("Кутник 40х40х3, м.п.", 52.7, "Кутник ст 40х40х3", "42999KP1", "Кутник ст 40х40х3", "TEZ0158", "м", "");

	public static CustomConst kutnyk45_45_4 = new CustomConst("Кутник 45х45х4, м.п.", 70.7, "Кутник ст 45х45х4", "37726KP1", "Кутник ст 45х45х4", "TEZ0159", "м", "");

	public static CustomConst kutnyk50_50_4 = new CustomConst("Кутник 50х50х4, м.п.", 80.6, "Кутник ст 50х50х4", "34388KP1", "Кутник ст 50х50х4", "TEZ0161", "м", "");

	public static CustomConst kutnyk63_63_4 = new CustomConst("Кутник 63х63х4, м.п.", 129.4, "Кутник ст 63х63х4", "77584KP1", "Кутник ст 63х63х4", "TEZ0001", "м", "");

	public static CustomConst hruntovkaHF = new CustomConst("Грунтовка ГФ, кг", 62.88, "Грунтовка ГФ-021 сіра 2.8кг, кг", "15907KP1", "Грунтовка ГФ-021 сіра 2.8кг, кг", "TEZ0343", "кг", "");

	public static CustomConst rozchynnyk647 = new CustomConst("Розчинник 647, л", 43.7879470904824, "Розчинник 647 1л-0,4кг", "149KP1", "Розчинник 647 (0,8л)", "TEZ0096", "шт", "");

	public static CustomConst dritObmidnenyj08 = new CustomConst("Дріт обміднений для звар апарат ф0.8, кг", 48.0, "Дріт обміднений для звар апарат ф0.8", "2695KP1", "Дріт обміднений для звар апарат ф0.8", "TEZ0408", "кг", "");

	public static CustomConst klejSecunda = new CustomConst("Клей 88 0,8кг", 187.5, "Клей 88 0,8кг", "28193KP1", "Клей 88", "TEZ0779", "кг", "");

	public static CustomConst hnuchkaVstavka45_60_45 = new CustomConst("Гнучка вставка  KEV  45-60-45, м.п.", 40.2192, "Гнучка вставка 45х60х45 (Китай)", "59157KP1", "Гнучка вставка 45х60х45", "TEZ0063", "м", "");

	public static CustomConst profilS20 = new CustomConst("Профіль S-20, м.п.", 17.5, "Профіль фланцевий (шинорейка) S20", "32919KP1", "Профіль фланцевий (шинорейка) S20", "TEZ0023", "м", "");

	public static CustomConst profilS30 = new CustomConst("Профіль S-30, м.п.", 24.5, "Профіль фланцевий (шинорейка) S30", "36251KP1", "Профіль фланцевий (шинорейка) S30", "TEZ0024", "м", "");

	public static CustomConst kutnykS20 = new CustomConst("Кутник S-20, шт", 2.2, "Кутник Р-20", "37KP1", "Кутник Р-20", "TEZ0961", "шт", "");

	public static CustomConst kutnykS30 = new CustomConst("Кутник S-30, шт", 4.26, "Кутник Р-30", "82KP1", "Кутник Р-30", "TEZ0964", "шт", "");

	public static CustomConst lystAljum03 = new CustomConst("Лист алюм. 0.3, м2", 98.876, "Лист алюм 0,3мм", "112KP1", "Лист алюм 0,3мм", "TEZ0553", "м2", "кг");

	public static CustomConst lystAljum05 = new CustomConst("Лист алюм. 0.5, м2", 171.45, "Лист алюм 0,5(1000х2000), м.кв.", "15917KP1", "Лист алюм 0,5(1000х2000), м.кв.", "TEZ0055", "м2", "кг");

	public static CustomConst lystAljum08 = new CustomConst("Лист ал. 0.8мм, м2", 458.58, "Лист алюм 0,8(1000х2000), м.кв.", "15919KP1", "Лист алюм 0,8(1000х2000), м.кв.", "TEZ0165", "м2", "кг");

	public static CustomConst drit2 = new CustomConst("Дріт н/ж. Ø2, м.п.", 2.8281, "Дріт нерж 2мм", "28773KP1", "Дріт нерж 2мм", "TEZ0407", "кг", "");

	public static CustomConst pruzyna22 = new CustomConst("Пружина (Ø2,2; L=6), шт", 4.2, "Пружина ф2.5", "73686KP1", "Пружина ф2.2х6х0.4", "TEZ0060", "шт", "");

	public static CustomConst hofrokorob165 = new CustomConst("Гофрокороб 165х165х175, шт", 2.88, "Гофрокороба 130х130х140", "21070KP1", "Гофрокороба 130х130х140", "TEZ0312", "шт", "");

	public static CustomConst hofrokorob225 = new CustomConst("Гофрокороб 225х225х175, шт", 4.8, "Гофрокороба 225х225х140", "23652KP1", "Гофрокороба 225х225х140", "TEZ0315", "шт", "");

	public static CustomConst hofrokorob255 = new CustomConst("Гофрокороб 255х255х175, шт", 5.48, "Гофрокороба 255х255х140", "23653KP1", "Гофрокороба 255х255х140", "TEZ0067", "шт", "");

	public static CustomConst hofrokorob320 = new CustomConst("Гофрокороб 320х320х175, шт", 8.46, "Гофрокороба 320х320х140", "23654KP1", "Гофрокороба 320х320х140", "TEZ0317", "шт", "");

	public static CustomConst zaklepkaKombinov48 = new CustomConst("Заклепка комбінована ф4х8, шт", 0.589291799742819, "Заклепка комбінов 4,8х22", "991KP1", "Заклепка комбінов 4,8х22", "TEZ0682", "шт", "");

	public static CustomConst zaklepkaKombinov32x8 = new CustomConst("Заклепка комбінов. 3,2х8, шт", 0.225107923502282, "Заклепка 3.2х8 (п=50шт./0.050кг)", "29235KP1", "Заклепка 3.2х8 (п=50шт./0.050кг)", "TEZ0107", "шт", "");

	public static CustomConst shurupTeks35 = new CustomConst("Шуруп самозасв. Текс WS 3.5х9.5, шт", 0.144, "Шуруп WS 3,5х9,5 оцинк", "40206KP1", "Шуруп WS 3,5х9,5 оцинк", "TEZ0728", "шт", "");

	public static CustomConst hofrovstavka400x100 = new CustomConst("Гофровставка 400х100, шт", 1.36, "Гофровставка 400х100", "109943KP1", "Гофровставка 400х100", "TEZ0576", "шт", "");

	public static CustomConst hofrovstavka453x125 = new CustomConst("Гофровставка 453x125, шт", 1.86, "Гофровставка 453x125", "109944KP1", "Гофровставка 453x125", "TEZ0577", "шт", "");

	public static CustomConst hofrovstavka506x150 = new CustomConst("Гофровставка 506х150, шт", 2.2, "Гофровставка 506х150", "109941KP1", "Гофровставка 506х150", "TEZ0574", "шт", "");

	public static CustomConst hofrovstavka526x160 = new CustomConst("Гофровставка 526х160, шт", 2.9, "Гофровставка 526х160", "109945KP1", "Гофровставка 526х160", "TEZ0578", "шт", "");

	public static CustomConst hofrovstavka606x200 = new CustomConst("Гофровставка 606х200, шт", 3.9, "Гофровставка 606х200", "108791KP1", "Гофровставка 606х200", "TEZ0579", "шт", "");

	public static CustomConst hofrovstavka796x250 = new CustomConst("Гофровставка 796х250, шт", 6.2, "Гофровставка 796х250", "109075KP1", "Гофровставка 796х250", "TEZ0580", "шт", "");

	public static CustomConst hofrovstavka916x315 = new CustomConst("Гофровставка 916х315, шт", 9.7, "Гофровставка 916х315", "109942KP1", "Гофровставка 916х315", "TEZ0575", "шт", "");

	public static CustomConst etyketkaKZK100 = new CustomConst("Етикетка \"100\", шт", 0.216, "Етикетка КЗК 100", "109959KP1", "Етикетка \"100\", 22х73,2мм", "TEZ0581", "шт", "");

	public static CustomConst etyketkaKZK125 = new CustomConst("Етикетка \"125\", шт", 0.216, "Етикетка КЗК 125", "109960KP1", "Етикетка \"125\", 22х73,2мм", "TEZ0582", "шт", "");

	public static CustomConst etyketkaKZK150 = new CustomConst("Етикетка \"150\", шт", 0.216, "Етикетка КЗК 150", "109961KP1", "Етикетка \"150\", 22х73,2мм", "TEZ0583", "шт", "");

	public static CustomConst etyketkaKZK160 = new CustomConst("Етикетка \"160\", шт", 0.216, "Етикетка КЗК 160", "109962KP1", "Етикетка \"160\", 22х73,2мм", "TEZ0584", "шт", "");

	public static CustomConst etyketkaKZK200 = new CustomConst("Етикетка \"200\", шт", 0.216, "Етикетка КЗК 200", "109963KP1", "Етикетка \"200\", 22х73,2мм", "TEZ0585", "шт", "");

	public static CustomConst etyketkaKZK250 = new CustomConst("Етикетка \"250\", шт", 0.216, "Етикетка КЗК 250", "109964KP1", "Етикетка \"250\", 22х73,2мм", "TEZ0586", "шт", "");

	public static CustomConst etyketkaKZK315 = new CustomConst("Етикетка \"315\", шт", 0.216, "Етикетка КЗК 315", "109965KP1", "Етикетка \"315\", 22х73,2мм", "TEZ0587", "шт", "");

	public static CustomConst etyketkaKZK355 = new CustomConst("Етикетка \"355\", шт", 0.216, "Етикетка КЗК 355", "109966KP1", "Етикетка \"355\", 22х73,2мм", "TEZ0588", "шт", "");

	public static CustomConst etyketkaKZK400 = new CustomConst("Етикетка \"400\", шт", 0.216, "Етикетка КЗК 400", "109967KP1", "Етикетка \"400\", 22х73,2мм", "TEZ0589", "шт", "");

	public static CustomConst azot1 = new CustomConst("Азот, шт", 1240.0, "Азот газоподібний спецвідбору", "96496KP1", "Азот газоподібний спец.відбору ", "TEZ0001", "шт", "");

	public static CustomConst azot2 = new CustomConst("Азот, шт", 1240.0, "Азот (заправка)99.999%", "87407KP1", "Азот спецвідбір (особливої чистоти99.999)40л/6,0м3", "TEZ0001", "шт", "");

	public static CustomConst boltM6_70 = new CustomConst("Болт М6х70, шт", 0.99468, "Болт М6х70 (1кг=60шт.), шт.", "21518KP1", "Болт М6х70 (1кг=60шт.), шт.", "TEZ0141", "шт", "");

	public static CustomConst hajkaM6 = new CustomConst("Гайка М6, шт", 0.139919867, "Гайка М6 оц (1кг=462 шт.), шт.", "15904KP1", "Гайка М6 оц (1кг=462 шт.)", "TEZ0052", "шт", "");

	public static CustomConst shajba6zbilshena = new CustomConst("Шайба 6 збільшена, шт", 0.19379990937429, "Шайба збільшена оц ф6 (1кг=400шт.), шт", "52769KP1", "Шайба збільшена оц ф6 (1кг=400шт.), шт", "TEZ0575", "шт", "");

	public static CustomConst komplectRuchkyDroselKlapana = new CustomConst("Комплект ручки дросель-клапана, шт", 11.196, "Комплект ручки дрос клапана", "60051KP1", "Комплект ручки дрос. клапана", "TEZ0137", "шт", "");

	public static CustomConst shurupWF42_19 = new CustomConst("Шуруп самозасв. WF 4,2х19, шт", 0.23856, "Шуруп WF 4,2х19 оцинк", "287KP1", "Шуруп WF 4,2х19 оцинк", "TEZ0349", "шт", "");

	public static CustomConst shurupWFS42_13 = new CustomConst("Шуруп самозасв. WFS 4,2х13, шт", 0.20195973073831, "Шуруп WFS 4,2х13 оцинк", "40674KP1", "Шуруп WFS 4,2х13 оцинк", "TEZ0352", "шт", "");

	public static CustomConst kvadrat10 = new CustomConst("Квадрат 10, м.п", 29.3117647058824, "Квадрат 10 ст 3 калібрований", "76969KP1", "Квадрат 10", "TEZ0129", "м", "");

	public static CustomConst polipropilen = new CustomConst("Поліпропілен, кг", 27.984, "Поліпропілен", "27958KP1", "Поліпропілен", "TEZ0224", "кг", "");

	public static CustomConst boltM6_20 = new CustomConst("Болт М6х20 грибок оц, шт", 0.500108, "Болт М6х20 грибок оц (1кг=153шт.), шт.", "15888KP1", "Болт М6х20 грибок оц (1кг=153шт.), шт.", "TEZ0034", "шт", "");

	public static CustomConst boltM6_12 = new CustomConst("Болт М6х12 'під ключ'оц.,шт", 0.352319111, "Болт М6х12  (1кг=226шт.), шт.", "25559KP1", "Болт М6х12  шест./гл. пов./різ.", "TEZ0032", "шт", "");

	public static CustomConst boltM8_35 = new CustomConst("Болт М8х35, шт", 1.11468, "Болт М8х35 (1кг=58 шт.), шт.", "15892KP1", "Болт М8х35 шест./гл.пов./різ.", "TEZ0150", "шт", "");

	public static CustomConst hajkaM6_Metelyk = new CustomConst("Гайка М6 метелик, шт", 0.66012, "Гайка М6 метелик", "43KP1", "Гайка М6 метелик", "TEZ0050", "шт", "");

	public static CustomConst hajkaM8 = new CustomConst("Гайка М8 оц, шт", 0.2915998968, "Гайка М8 оц (1кг=208 шт.), шт.", "53190KP1", "Гайка М8 оц (1кг=208 шт.)", "TEZ0053", "шт", "");

	public static CustomConst shajba_8 = new CustomConst("Шайба 8, шт", 0.1570799444, "Шайба 6 (1кг=892 шт.), шт.", "15957KP1", "Шайба 8 оц (1кг=485 шт.), шт.", "TEZ0330", "шт", "");

	public static CustomConst uschilnjuvach_ASS = new CustomConst("Ущільнювач ASS 6790, м.п.", 1.10502172264471, "Ущільнювач ASS 6790", "8852KP1", "Ущільнювач ASS 6789", "TEZ0452", "пог. м", "");

	public static CustomConst kruh24 = new CustomConst("Круг ф24, м.п", 71.7022222222222, "Круг 24", "1045KP1", "Круг 24", "TEZ0147", "пог. м", "");

	public static CustomConst ftoroplastF20 = new CustomConst("Фторопласт ф20, м.п", 336.0, "Фторопласт 25", "9KP1", "Фторопласт 25", "TEZ0498", "м", "кг");

	public static CustomConst etyketkaKDK100 = new CustomConst("Етикетка \"100 КДК\", шт", 0.192, "Етикетка КДК 100", "109950KP1", "Етикетка \"100 КДК\", 22х73,2мм", "TEZ0565", "шт", "");

	public static CustomConst etyketkaKDK125 = new CustomConst("Етикетка \"125 КДК\", шт", 0.192, "Етикетка КДК 125", "109951KP1", "Етикетка \"125 КДК\", 22х73,2мм", "TEZ0566", "шт", "");

	public static CustomConst etyketkaKDK150 = new CustomConst("Етикетка \"150 КДК\", шт", 0.192, "Етикетка КДК 150", "109952KP1", "Етикетка \"150 КДК\", 22х73,2мм", "TEZ0567", "шт", "");

	public static CustomConst etyketkaKDK160 = new CustomConst("Етикетка \"160 КДК\", шт", 0.192, "Етикетка КДК 160", "109953KP1", "Етикетка \"160 КДК\", 22х73,2мм", "TEZ0568", "шт", "");

	public static CustomConst etyketkaKDK200 = new CustomConst("Етикетка \"200 КДК\", шт", 0.192, "Етикетка КДК 200", "109954KP1", "Етикетка \"200 КДК\", 22х73,2мм", "TEZ0569", "шт", "");

	public static CustomConst etyketkaKDK250 = new CustomConst("Етикетка \"250 КДК\", шт", 0.192, "Етикетка КДК 250", "109955KP1", "Етикетка \"250 КДК\", 22х73,2мм", "TEZ0570", "шт", "");

	public static CustomConst etyketkaKDK315 = new CustomConst("Етикетка \"315 КДК\", шт", 0.192, "Етикетка КДК 315", "109956KP1", "Етикетка \"315 КДК\", 22х73,2мм", "TEZ0571", "шт", "");

	public static CustomConst etyketkaKDK355 = new CustomConst("Етикетка \"355 КДК\", шт", 0.192, "Етикетка КДК 355", "109957KP1", "Етикетка \"355 КДК\", 22х73,2мм", "TEZ0572", "шт", "");

	public static CustomConst etyketkaKDK400 = new CustomConst("Етикетка \"400 КДК\", шт", 0.192, "Етикетка КДК 400", "109958KP1", "Етикетка \"400 КДК\", 22х73,2мм", "TEZ0573", "шт", "");

	public static CustomConst profil0393 = new CustomConst("Профіль №0393, м.п", 91.4260408163265, "Профіль ламеля №0393", "39221KP1", "Профіль ламеля №0393", "TEZ0234", "пог. м", "кг");

	public static CustomConst uschilnjuvach1166 = new CustomConst("Ущільнювач сірий 1166, м.п", 8.22, "Ущільнювач 1166 сірий д/Ламеля", "39668KP1", "Ущільнювач 1166 сірий д/Ламеля", "TEZ0450", "пог. м", "");

	public static CustomConst shpylkaM10 = new CustomConst("Шпилька М10, м.п", 99.12, "Шпилька М10х2000 DIN 975 цб 8,8", "286KP1", "Шпилька М10х2000", "TEZ0323", "шт", "пог. м");

	public static CustomConst gajkaM10 = new CustomConst("Гайка М10, шт", 0.68796, "Гайка М10 (1кг=93шт.), шт.", "15897KP1", "Гайка М10 (1кг=98шт.)", "TEZ0043", "шт", "");

	public static CustomConst shajbaF10 = new CustomConst("Шайба ф10, шт", 0.23376023942381, "Шайба 10 оц (1кг=227шт.), шт.", "15959KP1", "Шайба 10 оц (1кг=227шт.), шт.", "TEZ0521", "шт", "");

	public static CustomConst shajbaGroverF10 = new CustomConst("Шайба гровер ф10, шт", 0.199080062376746, "Шайба гровер оц Ф10 (1кг=549шт.)", "7329KP1", "Шайба гровер оц Ф10 (1кг=549шт.)", "TEZ0542", "шт", "");

	public static CustomConst uschilnjuvachGumovyiD = new CustomConst("Ущільнювач гумовий D, м.п", 6.3, "Ущільнювач гумовий D", "17619KP1", "Ущільнювач гумовий D", "TEZ0457", "пог. м", "");

	public static CustomConst filtruvalnaTkanynaSyntepon = new CustomConst("Фільтрувальна тканина (синтепон), м2", 20.0, "Синтепон", "40KP1", "Синтепон", "TEZ0140", "м2", "");

	public static CustomConst zatyskach = new CustomConst("Затискач, шт", 20.2, "Затискач 802 оцинк", "82533KP1", "Затискач 802 оцинк", "TEZ0707", "шт", "");

	public static CustomConst hvynt9x11 = new CustomConst("Гвинт самозасв. М3.9х11, шт", 0.144, "Гвинт самосв  М3.9х11 шт.", "66151KP1", "Гвинт М3,9х11, шт.", "TEZ0056", "шт", "");

	public static CustomConst polosa30x4 = new CustomConst("Полоса 30х4, м.п", 25.5, "Полоса 30х4", "34762KP1", "Полоса 30х4", "TEZ0945", "пог. м", "");

	public static CustomConst plytaVermykulitova_114_108_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 114х108х20, шт", 8.76000546020965, "Плита верм-ва кру ПВН-О-700 114*108*20", "44722KP1", "Плита верм-ва  ПВН-О-700 114*108*20(кругла)", "TEZ0570", "шт", "");

	public static CustomConst plytaVermykulitova_139_133_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 139х133х20, шт", 13.0199895713688, "Плита верм-ва кру ПВН-О-700 139*133*20", "44603KP1", "Плита верм-ва  ПВН-О-700 139*133*20", "TEZ0593", "шт", "");

	public static CustomConst plytaVermykulitova_149_143_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 149х143х20, шт", 14.9639880142829, "Плита верм-ва кру ПВН-О-700 149*143*20", "44721KP1", "Плита верм-ва  ПВН-О-700 149*143*20", "TEZ0596", "шт", "");

	public static CustomConst plytaVermykulitova_169_163_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 169х163х20, шт", 24.0720179851, "Плита верм-ва кру ПВН-О-700 169*163*20", "44604KP1", "Плита верм-ва  ПВН-О-700 189*183*20", "TEZ0220", "шт", "");

	public static CustomConst plytaVermykulitova_189_183_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 189х183х20, шт", 24.0719807190469, "Плита верм-ва кру ПВН-О-700 189*183*20", "44604KP1", "Плита верм-ва  ПВН-О-700 189*183*20", "TEZ0220", "шт", "");

	public static CustomConst plytaVermykulitova_239_233_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 239х233х20, шт", 38.4960756367409, "Плита верм-ва кру ПВН-О-700 239*233*20", "44720KP1", "Плита верм-ва  ПВН-О-700 239*233*20", "TEZ0622", "шт", "");

	public static CustomConst plytaVermykulitova_304_298_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 304х298х20, шт", 62.27995011558, "Плита верм-ва кру ПВН-О-700 304*298*20", "44714KP1", "Плита верм-ва  ПВН-О-700 304*298*20", "TEZ0639", "шт", "");

	public static CustomConst plytaVermykulitova_344_338_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 344х338х20, шт", 129.8760970351, "Плита верм-ва кру ПВН-О-700 344*338*20", "49794KP1", "Плита верм-ва  ПВН-О-700 344*338*20", "TEZ0653", "шт", "");

	public static CustomConst plytaVermykulitova_389_383_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 389х383х20, шт", 129.8760970351, "Плита верм-ва кру ПВН-О-700 389*383*20", "49794KP1", "Плита верм-ва кру ПВН-О-700 389*383*20", "TEZ0883", "шт", "");

	public static CustomConst plytaVermykulitova_439_433_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 439х433х20, шт", 129.876666, "Плита верм-ва кру ПВН-О-700 439*433*20", "49794KP1", "Плита верм-ва кру ПВН-О-700 439*433*20", "TEZ0885", "шт", "");

	public static CustomConst plytaVermykulitova_489_483_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 489х483х20, шт", 258.2166666, "Плита верм-ва кру ПВН-О-700 489*483*20", "49072KP1", "Плита верм-ва кру ПВН-О-700 489*483*20", "TEZ0889", "шт", "");

	public static CustomConst plytaVermykulitova_549_543_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 549х543х20, шт", 258.2166666, "Плита верм-ва кру ПВН-О-700 549*543*20", "49072KP1", "Плита верм-ва кру ПВН-О-700 549*543*20", "TEZ0892", "шт", "");

	public static CustomConst plytaVermykulitova_619_613_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 619х613х20, шт", 258.2166666, "Плита верм-ва кру ПВН-О-700 619*613*20", "49072KP1", "Плита верм-ва кру ПВН-О-700 619*613*20", "TEZ0897", "шт", "");

	public static CustomConst plytaVermykulitova_699_693_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 699х693х20, шт", 416.34, "Плита верм-ва кру ПВН-О-700 699*693*20", "56579KP1", "Плита верм-ва кру ПВН-О-700 699*693*20", "TEZ0899", "шт", "");

	public static CustomConst plytaVermykulitova_789_783_20 = new CustomConst("Плита вермикулітова ПВН-О-700 круг 789х783х20, шт", 416.34, "Плита верм-ва кру ПВН-О-700 789*783*20", "56579KP1", "Плита верм-ва кру ПВН-О-700 789*783*20", "TEZ0902", "шт", "");

	public static CustomConst ohraks = new CustomConst("Стрічка KeraFix Flexpan 200 NG-G 20мм Х 2, м.п", 29.008, "Огракс-Л 2х20мм на клейкій основі", "88556KP1", "Стрічка Kerafix Flexpan 200 NG-G 20мм х 2,0м", "TEZ0279", "м", "");

	public static CustomConst kruh6 = new CustomConst("Круг ф6, м.п", 11.8260869565217, "Круг ст 20 ф6 ммкалібрований", "23380KP1", "Круг 6 ст20", "TEZ0851", "пог. м", "");

	public static CustomConst kruh16 = new CustomConst("Круг ф16, м.п", 42.204116, "Круг 16", "79KP1", "Круг 16", "TEZ0842", "пог. м", "");

	public static CustomConst kruh22 = new CustomConst("Круг 22, м.п", 78.350277, "Круг 22", "13716KP1", "Круг 22", "TEZ0146", "пог. м", "");

	public static CustomConst kruh12 = new CustomConst("Круг 12, м.п", 24.3, "Круг 12", "121KP1", "Круг 12", "TEZ0143", "пог. м", "");

	public static CustomConst kruh18LC59 = new CustomConst("Круг 18 ЛС59, м.п", 1283.436, "Круг ЛС-59 ф18(латунь)", "73821KP1", "Круг ЛС-59 д18", "TEZ0150", "пог. м", "");

	public static CustomConst uschilnjuvachThermasheet = new CustomConst("Ущільнювач Thermasheet, м2", 143.376, "Ущільнювач Thermasheet FR-5", "13855KP1", "Ущільнювач Thermasheet FR-5", "TEZ0453", "м2", "");

	public static CustomConst sclotekstolitSTEF = new CustomConst("Склотекстоліт СТЕФ 1-0.5, м2", 156.0, "Склотекстоліт СТЕФ 1-0.5", "34763KP1", "Склотекстоліт СТЕФ 1-0.5", "TEZ0181", "кг", "");

	public static CustomConst truba15x28 = new CustomConst("Труба 15х2.8, м.п", 25.2960344884002, "Труба ДУ 15х2.5", "39427KP1", "Труба ДУ 15х2.5", "TEZ0291", "пог. м", "");

	public static CustomConst pruzyna08x10 = new CustomConst("Пружина ф0.8х10 (КПК 1500007), шт", 3.36, "Пружина ф0.8мм", "55417KP1", "Пружина ф 0.8", "TEZ0048", "шт", "");

	public static CustomConst pruzyna30 = new CustomConst("Пружина ф3, шт", 24.0, "Пружина ф3.0", "53592KP1", "Пружина ф3.0", "TEZ0062", "шт", "");

	public static CustomConst pruzyna40 = new CustomConst("Пружина ф4, шт", 24.0, "Пружина ф4.0", "53593KP1", "Пружина ф4.0", "TEZ0066", "шт", "");

	public static CustomConst pruzyna50 = new CustomConst("Пружина ф5, шт", 28.8, "Пружина ф5.0", "66845KP1", "Пружина ф5.0", "TEZ0069", "шт", "");

	public static CustomConst zamokTeplovyj72C = new CustomConst("Замок тепловий 72°С, шт", 42.375, "Замок тепловий 72С", "162KP1", "Замок тепловий 72С", "TEZ0700", "шт", "");

	public static CustomConst farbaAerozol = new CustomConst("Фарба аерозоль 400 мл, шт", 65.0, "Фарба аероз 400 мл.", "11148KP1", "Фарба аероз 400 мл.", "TEZ0465", "шт", "");

	public static CustomConst vymykachASKO = new CustomConst("Вимикач АСКО МЕ 8112, шт", 63.18, "Кінцевий вимикач АСКО МЕ 8122", "38470KP1", "Кінцевий вимикач АСКО МЕ 8112", "TEZ0766", "шт", "");

	public static CustomConst sylicon = new CustomConst("Силікон СНЕМКО 280мл проз, шт", 48.0, "Силікон СНЕМКО 280мл проз", "111KP1", "Силікон СНЕМКО 280мл проз", "TEZ0137", "шт", "");

	public static CustomConst hvyntM6x12 = new CustomConst("Гвинт М6х12, шт", 0.63, "Гвинт циліндр оц М6х12 (1кг=234шт), шт.", "18269KP1", "Гвинт М6х12 цикл/гл нпкр РН ЦБ", "TEZ0059", "шт", "");

	public static CustomConst boltM6_25 = new CustomConst("Болт М6х25, шт", 0.381839669666007, "Болт М6х25  (1кг=171шт.), шт.", "87050KP1", "Болт М6х25  шест./гл.пов./різ. шт.", "TEZ0035", "шт", "");

	public static CustomConst shajba5 = new CustomConst("Шайба 5, шт", 0.0933599669, "Шайба 6 (1кг=892 шт.), шт.", "15957KP1", "Шайба 5 (1кг=292 шт.), шт.", "TEZ0533", "шт", "");

	public static CustomConst shajba6 = new CustomConst("Шайба 6, шт", 0.0933599669, "Шайба 6 (1кг=892 шт.), шт.", "15957KP1", "Шайба ф 6", "TEZ0329", "шт", "");

	public static CustomConst shajbaPidshypnykShtoporneKiltse6 = new CustomConst("Підшипник штоп. кільце ф6,шт", 0.9, "Підшипникстопорне к-це d=6 DIN-471зовн", "14816KP1", "Підшипник стопорне к-це d=6 DIN-471", "TEZ0218", "шт", "");

	public static CustomConst bolt5_35 = new CustomConst("Болт М5х35, шт", 0.5491333333333, "Болт М5х35 шест./гл., шт.", "49806KP1", "Болт М5х35 шест./гл.,", "TEZ0030", "шт", "");

	public static CustomConst bolt5_30 = new CustomConst("Болт М5х30, шт", 0.66, "Болт М5х30 (1кг=204шт.), шт.", "53739KP1", "Болт М5х30  шест./гл.пов.", "TEZ0029", "шт", "");

	public static CustomConst hajkaM5 = new CustomConst("Гайка М5, шт", 0.0911999677, "Гайка М5 оц (1кг=961 шт.),  шт", "19881KP1", "Гайка М5 оц (1кг=961 шт.)", "TEZ0230", "шт", "");

	public static CustomConst hvynt5x10 = new CustomConst("Гвинт М5х10, шт", 0.257602339181287, "Гвинт М5х10 потай ,шт", "27933KP1", "Гвинт М5х10 потай ,шт", "TEZ0262", "шт", "");

	public static CustomConst boltM6x15 = new CustomConst("Болт метелик М6х15, шт", 7.95, "Гвинт М6х16 баранц DIN316А, шт.", "115045KP1", "Гвинт М6х10 баранц цб", "TEZ0733", "шт", "");

	public static CustomConst shurupWS42_19 = new CustomConst("Шуруп WS 4,2x19, шт", 0.1813199358, "Шуруп WF 4,2х19 оцинк", "287KP1", "Шуруп WFS 4,2х19 оцинк", "TEZ0353", "шт", "");

	public static CustomConst naklejkaTEZ = new CustomConst("Наклейка ТЕЗ, шт", 0.72, "Наклейка КП", "18677KP1", "Наклейки ТЕЗ", "TEZ0448", "шт", "");

	public static CustomConst plivkaStrech = new CustomConst("Плівка стреч 300м, шт", 105.42, "Плівка поліетиленова РЕ-17 2,1 кг", "95693KP1", "Плівка стреч 300м", "TEZ0223", "шт", "");

	public static CustomConst shurup35x95 = new CustomConst("Шуруп самозасвердлюючий 3.5х9.5, шт", 0.123, "Шуруп WS 3,5х9,5 оцинк", "129KP1", "Шуруп 3.5х13", "TEZ0347", "шт", "");

	public static CustomConst pruzyna25 = new CustomConst("Пружина ф2.5, шт", 4.2, "Пружина ф2.5", "73686KP1", "Пружина ф 2.5", "TEZ0052", "шт", "");

	public static CustomConst farbaSribljasta = new CustomConst("Фарба срібляста, кг", 61.0, "Фарба аероз 400 мл.", "11148KP1", "Фарба аероз 400 мл. срібло", "TEZ0324", "кг", "");

	public static CustomConst shajbaGroverF6 = new CustomConst("Шайба гровер ф6, шт", 0.15888, "Шайба гровер оц ф8 (1кг=620шт.), шт.", "32925KP1", "Шайба гровер оц ф6 (1кг=2777шт.), шт.", "TEZ0549", "шт", "");

	public static CustomConst kvadrat14 = new CustomConst("Квадрат 14, м.п", 36.8040258972638, "Квадрат 14", "33831KP1", "Квадрат 14", "TEZ0742", "м", "");

	public static CustomConst servopryvidBFL_230Т = new CustomConst("Сервопривід BFL-230Т, шт", 3523.392, "Сервопривід BFL230-T", "73953KP1", "Сервопривід BFL230-Т", "TEZ0260", "шт", "");

	public static CustomConst servopryvidBFN_230Т = new CustomConst("Сервопривід BFN-230Т, шт", 4071.865, "Сервопривід BFN230-T", "73421KP1", "Сервопривід BFN230 -T-2", "TEZ0769", "шт", "");

	public static CustomConst servopryvidBFL_24T = new CustomConst("Сервопривід BFL-24T, шт", 3470.865, "Сервопривід BFL230-T", "73953KP1", "Сервопривід BFL 24 - Т", "TEZ0775", "шт", "");

	public static CustomConst servopryvidBFN_24T = new CustomConst("Сервопривід BFN-24T, шт", 4035.19627559535, "Сервопривід BFN230-T", "73421KP1", "Сервопривід BFN24 - T", "TEZ0768", "шт", "");

	public static CustomConst servopryvidCM_24 = new CustomConst("Сервопривід CM-24, шт", 3800.0, "Сервопривід CM-24", "", "Сервопривід CM-24", "", "шт", "");

	public static CustomConst servopryvidCM_230 = new CustomConst("Сервопривід CM-230, шт", 3800.0, "Сервопривід CM-230", "", "Сервопривід CM-230", "", "шт", "");

	public static CustomConst servopryvidLM_24 = new CustomConst("Сервопривід LM-24, шт", 3800.0, "Сервопривід LM-24", "", "Сервопривід LM-24", "", "шт", "");

	public static CustomConst servopryvidLM_230 = new CustomConst("Сервопривід LM-230, шт", 3800.0, "Сервопривід LM-230", "", "Сервопривід LM-230", "", "шт", "");

	public static CustomConst servopryvidTF_24 = new CustomConst("Сервопривід TF-24, шт", 3800.0, "Сервопривід TF-24", "", "Сервопривід TF-24", "", "шт", "");

	public static CustomConst servopryvidTF_230 = new CustomConst("Сервопривід TF-230, шт", 3800.0, "Сервопривід TF-230", "", "Сервопривід TF-230", "", "шт", "");

	public static CustomConst servopryvidLF_24 = new CustomConst("Сервопривід LF-24, шт", 3800.0, "Сервопривід LF-24", "", "Сервопривід LF-24", "", "шт", "");

	public static CustomConst servopryvidLF_230 = new CustomConst("Сервопривід LF-230, шт", 3800.0, "Сервопривід LF-230", "", "Сервопривід LF-230", "", "шт", "");

	public static CustomConst boltM6_60 = new CustomConst("Болт М6х60, шт", 1.72, "Болт М6х60 (1кг=74шт.), шт.", "66225KP1", "Болт М6х60 оц шест./гл.пов./різ.", "TEZ0140", "шт", "");

	public static CustomConst boltM6_55 = new CustomConst("Болт М6х55, шт", 1.72, "Болт М6х55 (1кг=85шт.), шт.", "15890KP1", "Болт М6х55 оц шест./гл.пов./різ.", "", "шт", "");

	public static CustomConst shajba6zbilshena5 = new CustomConst("Шайба збільшена 5 (18), шт", 0.19379990937429, "Шайба збільшена оц ф6 (1кг=400шт.), шт", "52769KP1", "Шайба збільшена оц ф5 (1кг=847шт.), шт", "TEZ0574", "шт", "");

	public static CustomConst plytaVermykulitova_87_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 87х188х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 87*188*20", "44722KP1", "Плита верм-ва  ПВН-О-700  87*188*20", "TEZ0555", "шт", "");

	public static CustomConst plytaVermykulitova_127_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 127х188х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 127*188*20", "44722KP1", "Плита верм-ва  ПВН-О-700 137*138*20", "TEZ0590", "шт", "");

	public static CustomConst plytaVermykulitova_127_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 127х238х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 127*238*20", "44722KP1", "Плита верм-ва  ПВН-О-700 137*138*20", "TEZ0590", "шт", "");

	public static CustomConst plytaVermykulitova_137_138_20 = new CustomConst("Плита вермикулітова ПВН-О-700 137х138х20, шт", 10.6199964678, "Плита верм-ва  ПВВ-700 137*138*20", "55157KP1", "Плита верм-ва  ПВН-О-700 137*138*20", "TEZ0590", "шт", "");

	public static CustomConst plytaVermykulitova_147_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 147х188х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 147*188*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_147_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 147х238х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 147*238*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_147_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 147х303х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 147*303*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_167_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 167х188х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 167*188*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_167_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 167х238х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 167*238*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_167_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 167х303х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 167*303*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_167_343_20 = new CustomConst("Плита вермикулітова ПВН-О-700 167х343х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 167*343*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_167_388_20 = new CustomConst("Плита вермикулітова ПВН-О-700 167х388х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 167*388*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_187_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 187х188х20, шт", 25.0200203798372, "Плита верм-ва  ПВН-О-700 187*188*20", "44722KP1", "Плита верм-ва  ПВН-О-700 187*188*20", "TEZ0603", "шт", "");

	public static CustomConst plytaVermykulitova_237_138_20 = new CustomConst("Плита вермикулітова ПВН-О-700 237х138х20, шт", 18.3719852845767, "Плита верм-ва  ПВН-О-700 237*138*20", "53737KP1", "Плита верм-ва  ПВН-О-700 237*138*20", "TEZ0617", "шт", "");

	public static CustomConst plytaVermykulitova_237_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 237х188х20, шт", 25.0200203798372, "Плита верм-ва  ПВВ-700 237*188*20", "55153KP1", "Плита верм-ва  ПВН-О-700 237*188*20", "TEZ0618", "шт", "");

	public static CustomConst plytaVermykulitova_237_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 237х238х20, шт", 31.6800258046859, "Плита верм-ва  ПВВ-700 237*238*20", "44989KP1", "Плита верм-ва  ПВН-О-700 237*238*20", "TEZ0619", "шт", "");

	public static CustomConst plytaVermykulitova_287_138_20 = new CustomConst("Плита вермикулітова ПВН-О-700 287х138х20, шт", 22.2480199388, "Плита верм-ва  ПВВ-700 287*138*20", "94695KP1", "Плита верм-ва  ПВН-О-700 287*138*20", "TEZ0631", "шт", "");

	public static CustomConst plytaVermykulitova_302_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 302х188х20, шт", 29.9880224051, "Плита верм-ва  ПВН-О-700 302*188*20", "44722KP1", "Плита верм-ва  ПВН-О-700 302*188*20", "TEZ0638", "шт", "");

	public static CustomConst plytaVermykulitova_302_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 302х238х20, шт", 29.9880224051, "Плита верм-ва  ПВН-О-700 302*238*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_302_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 302х303х20, шт", 29.9880224051, "Плита верм-ва  ПВН-О-700 302*303*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_342_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 342х188х20, шт", 29.9880224051, "Плита верм-ва  ПВН-О-700 342*188*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_342_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 342х238х20, шт", 29.9880224051, "Плита верм-ва  ПВН-О-700 342*238*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_342_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 342х303х20, шт", 29.9880224051, "Плита верм-ва  ПВН-О-700 342*303*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_342_343_20 = new CustomConst("Плита вермикулітова ПВН-О-700 342х343х20, шт", 29.9880224051, "Плита верм-ва  ПВН-О-700 342*343*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_387_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 387х188х20, шт", 29.9880268754, "Плита верм-ва  ПВВ-700 387*138*20", "93941KP1", "Плита верм-ва  ПВН-О-700 387*138*20", "TEZ0661", "шт", "");

	public static CustomConst plytaVermykulitova_387_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 387х238х20, шт", 51.7320386509, "Плита верм-ва  ПВВ-700 387*238*20", "55162KP1", "Плита верм-ва  ПВН-О-700 387*238*20", "TEZ0663", "шт", "");

	public static CustomConst plytaVermykulitova_387_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 387х303х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 387*303*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_387_343_20 = new CustomConst("Плита вермикулітова ПВН-О-700 387х343х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 387*343*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_387_388_20 = new CustomConst("Плита вермикулітова ПВН-О-700 387х388х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 387*388*20", "44722KP1", "Плита верм-ва  ПВН-О-700 387*388*20", "TEZ0666", "шт", "");

	public static CustomConst plytaVermykulitova_388_137_20 = new CustomConst("Плита вермикулітова ПВН-О-700 388х137х20, шт", 29.856, "Плита верм-ва  ПВВ-700 388*137*20", "99511KP1", "Плита верм-ва  ПВН-О-700 388*137*20", "TEZ0668", "шт", "");

	public static CustomConst plytaVermykulitova_437_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 437х188х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 437*188*20", "44722KP1", "Плита верм-ва  ПВН-О-700 437*188*20", "TEZ0676", "шт", "");

	public static CustomConst plytaVermykulitova_437_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 437х238х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 437*238*20", "44722KP1", "Плита верм-ва  ПВН-О-700 437*238*20", "TEZ0677", "шт", "");

	public static CustomConst plytaVermykulitova_437_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 437х303х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 437*303*20", "44722KP1", "Плита верм-ва  ПВН-О-700 437*303*20", "TEZ0679", "шт", "");

	public static CustomConst plytaVermykulitova_437_343_20 = new CustomConst("Плита вермикулітова ПВН-О-700 437х343х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 437*343*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_437_388_20 = new CustomConst("Плита вермикулітова ПВН-О-700 437х388х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 437*388*20", "44722KP1", "Плита верм-ва  ПВН-О-700 437*388*20", "TEZ0681", "шт", "");

	public static CustomConst plytaVermykulitova_437_438_20 = new CustomConst("Плита вермикулітова ПВН-О-700 437х438х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 437*438*20", "44722KP1", "Плита верм-ва  ПВН-О-700 437*438*20", "TEZ0682", "шт", "");

	public static CustomConst plytaVermykulitova_487_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 487х188х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 437*438*20", "44722KP1", "", "44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_487_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 487х238х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 487*238*20", "44722KP1", "Плита верм-ва  ПВН-О-700 487*238*20", "TEZ0690", "шт", "");

	public static CustomConst plytaVermykulitova_487_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 487х303х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 487*303*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_487_343_20 = new CustomConst("Плита вермикулітова ПВН-О-700 487х343х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 487*343*20", "44722KP1", "Плита верм-ва  ПВН-О-700 487*343*20", "TEZ0693", "шт", "");

	public static CustomConst plytaVermykulitova_487_388_20 = new CustomConst("Плита вермикулітова ПВН-О-700 487х388х20, шт", 106.1159136746, "Плита верм-ва  ПВН-О-700 487*388*20", "55163KP1", "Плита верм-ва  ПВН-О-700 487*388*20", "TEZ0694", "шт", "");

	public static CustomConst plytaVermykulitova_487_438_20 = new CustomConst("Плита вермикулітова ПВН-О-700 487х438х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 487*438*20", "44722KP1", "Плита верм-ва  ПВН-О-700 487*438*20", "TEZ0695", "шт", "");

	public static CustomConst plytaVermykulitova_487_488_20 = new CustomConst("Плита вермикулітова ПВН-О-700 487х488х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 487*488*20", "44722KP1", "Плита верм-ва  ПВН-О-700 487*488*20", "TEZ0696", "шт", "");

	public static CustomConst plytaVermykulitova_547_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 547х188х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 547*188*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_547_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 547х238х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 547*238*20", "44722KP1", "Плита верм-ва  ПВН-О-700 547*238*20", "TEZ0709", "шт", "");

	public static CustomConst plytaVermykulitova_547_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 547х303х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 547*303*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_547_343_20 = new CustomConst("Плита вермикулітова ПВН-О-700 547х343х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 547*343*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_547_388_20 = new CustomConst("Плита вермикулітова ПВН-О-700 547х388х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 547*388*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_547_438_20 = new CustomConst("Плита вермикулітова ПВН-О-700 547х438х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 547*438*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_547_488_20 = new CustomConst("Плита вермикулітова ПВН-О-700 547х488х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 547*488*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_587_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 587х238х20, шт", 78.4560703128, "Плита верм-ва  ПВВ-700 587*238*20", "99514KP1", "Плита верм-ва  ПВН-О-700 587*238*20", "TEZ0717", "шт", "");

	public static CustomConst plytaVermykulitova_617_188_20 = new CustomConst("Плита вермикулітова ПВН-О-700 617х188х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 617*188*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_617_238_20 = new CustomConst("Плита вермикулітова ПВН-О-700 617х238х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 617*238*20", "44722KP1", "Плита верм-ва  ПВН-О-700 617*238*20", "TEZ0730", "шт", "");

	public static CustomConst plytaVermykulitova_617_303_20 = new CustomConst("Плита вермикулітова ПВН-О-700 617х303х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 617*303*20", "44722KP1", "Плита верм-ва  ПВН-О-700 617*303*20", "TEZ0731", "шт", "");

	public static CustomConst plytaVermykulitova_617_343_20 = new CustomConst("Плита вермикулітова ПВН-О-700 617х343х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 617*343*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_617_388_20 = new CustomConst("Плита вермикулітова ПВН-О-700 617х388х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 617*388*20", "44722KP1", "Плита верм-ва  ПВН-О-700 617*388*20", "TEZ0732", "шт", "");

	public static CustomConst plytaVermykulitova_617_438_20 = new CustomConst("Плита вермикулітова ПВН-О-700 617х438х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 617*438*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_617_488_20 = new CustomConst("Плита вермикулітова ПВН-О-700 617х488х20, шт", 51.7320386509, "Плита верм-ва  ПВН-О-700 617*488*20", "44722KP1", "", "TEZ44722KP1", "шт", "");

	public static CustomConst plytaVermykulitova_637_388_20 = new CustomConst("Плита вермикулітова ПВН-О-700 637х388х20, шт", 138.8038479412, "Плита верм-ва  ПВВ-700 637*388*20", "88107KP1", "Плита верм-ва  ПВН-О-700 637*388*20", "TEZ0741", "шт", "");

	public static CustomConst plytaVermykulitova_837_288_20 = new CustomConst("Плита вермикулітова ПВН-О-700 837х288х20, шт", 135.3718517009, "Плита верм-ва  ПВВ-700 837*288*20", "99078KP1", "Плита верм-ва  ПВН-О-700 837*288*20", "TEZ0798", "шт", "");

	public static CustomConst plytaVermykulitova_937_288_20 = new CustomConst("Плита вермикулітова ПВН-О-700 937х288х20, шт", 151.5481358183, "Плита верм-ва  ПВВ-700 937*288*20", "101735KP1", "", "TEZ001735KP1", "шт", "");

	public static CustomConst plytaVermykulitova_1107_788_20 = new CustomConst("Плита вермикулітова ПВН-О-700 1107х788х20, шт", 489.8888212308, "Плита верм-ва  ПВВ-700 1107*788*20", "85913KP1", "Плита верм-ва  ПВН-О-700 1107*788*20", "TEZ0565", "шт", "");

	public static CustomConst plytaVermykulitova_1237_788_20 = new CustomConst("Плита вермикулітова ПВН-О-700 1237х788х20, шт", 547.4278179267, "Плита верм-ва  ПВВ-700 1237*788*20", "97328KP1", "Плита верм-ва  ПВН-О-700 1237*788*20", "TEZ0219", "шт", "");

	public static CustomConst paletsNaKlapanServ = new CustomConst("Палець на клапани з сервоприводом, шт", 60.0, "Палець на клапани з сервоприводом", "111744KP1", "Палець на клапани з сервоприводом", "", "шт", "");

	public static CustomConst sitka25x25 = new CustomConst("Сітка ОЦ (25х25), м2", 59.26666666, "Сітка 25х25х1.4", "40541KP1", "Сітка 25х25х1.4", "TEZ0153", "м2", "");

	public static CustomConst mastOholodRidynaECOCOOL_МК_3 = new CustomConst("Мастильно-охолодж. рідина, л", 130.431, "Мастильно-охолодж. рідина ECOCOOL МК 3", "13547KP1", "Мастильно-холодильна рідина ECOCOOL MK3", "TEZ0197", "л", "");

	public static CustomConst mastOholodRidynaECOCOOL_МК_6 = new CustomConst("Мастильно-охолодж. рідина, л", 130.431, "Мастильно-охолодж. рідина ECOCOOL МК 6", "57068KP1", "Мастильно-холодильна рідина ECOCOOL MK6", "TEZ0392", "л", "");

	public static CustomConst sitka25x25x1_8 = new CustomConst("Сітка ОЦ (25х25х1.8), м2", 59.26666666, "Сітка 25х25х1.8", "38644KP1", "Сітка 25х25х1.8", "TEZ0153", "м2", "");

	public static CustomConst mineralnaVataRoklait50mm = new CustomConst("Вата мінеральна, м2", 54.0480034722222, "Мін вата Роклайт 50мм", "34425KP1", "Мін вата Технолайт Екстра 50мм", "TEZ0202", "м2", "");

	public static CustomConst mineralnaVataTehno50mm = new CustomConst("Вата мінеральна, м2", 54.0480034722222, "Мін вата Технолайт Екстра 50мм", "34014KP1", "Мін вата Технолайт Екстра 50мм", "TEZ0204", "м2", "");

	public static CustomConst sklotkanynaTG_140 = new CustomConst("Склотканина, м2", 16.8, "Склотканина ТГ-140", "54966KP1", "Склотканина TG-140 (100)", "TEZ0267", "м2", "");

	public static CustomConst sklotkanynaTG_140P = new CustomConst("Склотканина, м2", 14.44, "Склотканина теплоіз ТГ-140П(100)", "41280KP1", "Склотканина теплоіз ТГ-140П (100)", "TEZ0185", "м2", "");

	public static CustomConst zaklepkaKombinov32x6 = new CustomConst("Заклепки комбіновані(ніти) 3.2х6, шт", 0.215973333333333, "Заклепка 3.2х6(п= 50шт./0.047кг)", "35964KP1", "Заклепка комбінов 3,2х6", "TEZ0670", "шт", "");

	public static CustomConst skotch48x200 = new CustomConst("Скотч прозорий, шт", 20.4, "Скотч пакувальний 48х200м", "66858KP1", "", "", "шт", "");

	public static CustomConst skotch48x100 = new CustomConst("Скотч прозорий, шт", 20.4, "Скотч пакувальний 48х100м", "22115KP1", "", "", "шт", "");

	public static CustomConst rulonAD_K_Flex06x1500 = new CustomConst("Рулон AD K-Flex 06x1500-30 ST DUCT NET", 366.96, "Рулон AD K-Flex 06x1500-30 ST DUCT NET", "94767KP1", "Рулон AD K-FLEX 06х1000х30ST", "TEZ0250", "м2", "");

	public static CustomConst zavisaRoyalna1_7 = new CustomConst("Завіса рояльна 1.7 пог.м", 138.364285714286, "Завіса рояльна 1.7 пог.м", "34662KP1", "Петля рояльна сталь нікельована 32мм 3,5м", "TEZ0790", "пог.м", "");

	public static CustomConst zaklepka3_2x6 = new CustomConst("Заклепка 3.2х6 (п=50шт./0.047кг)", 0.3, "Заклепка 3.2х6 (п=50шт./0.047кг)", "35964KP1", "Заклепка 3.2х6 (п=50шт./0.047кг)", "TEZ0106", "шт", "");

	public static CustomConst arhonLinde = new CustomConst("Аргон (заправка) вищий сорт Лінде", 1440.0, "Аргон (заправка) вищий сорт Лінде", "115126KP1", "Аргон (заправка) вищий сорт Лінде", "", "шт", "");

	public static CustomConst zatyskach802 = new CustomConst("Затискач 802 А2 нерж", 66.0, "Затискач 802 А2 нерж", "80625KP1", "Затискач 802 А2 нерж", "", "шт", "");

	public static CustomConst dritOkTigrod = new CustomConst("Дріт OK Tigrod 308Lsi 1.2х1000мм", 428.0, "Дріт OK Tigrod 308Lsi 1.2х1000мм", "77580KP1", "Дріт OK Tigrod 308Lsi 1.2х1000мм", "", "кг", "");

	public static CustomConst zaklepkaKombinov4x6 = new CustomConst("Заклепка комбінована 4,0х6", 0.34, "Заклепка комбінована 4,0х6", "994KP1", "Заклепка комбінована 4,0х6", "", "шт", "");

	public static CustomConst zaklepkaKombinov4x8 = new CustomConst("Заклепка комбінована 4,0х8", 0.42, "Заклепка комбінована 4,0х8", "7133KP1", "Заклепка комбінована 4,0х8", "", "шт", "");

	public static CustomConst sitkaProsVyt10x25x08 = new CustomConst("Сітка просічно-витяжна 7-10×25×0.8 ОЦ, м2", 59.28, "Сітка просічно-витяжна 7-10×25×0.8 ОЦ, м2", "119298KP1", "Сітка просічно-витяжна 7-10×25×0.8 ОЦ, м2", "", "м2", "");

	public static CustomConst hajkaM6_05_25 = new CustomConst("Гайка М6/0,5-2,5 клеп рифл зм.пот., шт", 2.364, "Гайка М6/0,5-2,5 клеп рифл зм.пот., шт", "119331KP1", "Гайка М6/0,5-2,5 клеп рифл зм.пот., шт", "", "шт", "");

	public static CustomConst hvyntBarancM6x10 = new CustomConst("Гвинт М6×10 баранц цб, шт", 9.19, "Гвинт М6×10 баранц цб, шт", "116526KP1", "Гвинт М6×10 баранц цб, шт", "", "шт", "");

	public static CustomConst zaklepkaKombinov48x10 = new CustomConst("Заклепка ф4.8х10, шт", 0.36662787541, "Заклепка комбінов 4,8х10", "17620KP1", "Заклепка комбінов 4,8х10", "TEZ0677", "шт", "");

	public static CustomConst zaklepkaKombinov48x12 = new CustomConst("Заклепка ф4.8х12, шт", 0.394319865999519, "Заклепка комбінов 4,8х12", "553KP1", "Заклепка комбінов 4,8х12", "TEZ0116", "шт", "");

	public static CustomConst boltM6x16 = new CustomConst("Болт М6х16, шт", 0.352319111, "Болт М6х16 оц (1кг=196 шт.) шт", "24814KP1", "Болт М6х16 оц шест./гл.пов./різ.", "TEZ0033", "шт", "");

	public static CustomConst lystStalnyj50 = new CustomConst("Лист ст3 5мм, м2", 1383.04, "Лист ст 5 1,5х6, м.кв.", "15945KP1", "Лист ст г/к 5мм 1,5х6 м.кв", "TEZ0189", "м2", "кг");

	public static CustomConst lystStalnyj60 = new CustomConst("Лист ст3 6мм, м2", 1400.0, "Лист ст г/к 6мм 1,5х6,0 м.кв", "32668KP1", "Лист ст г/к 6мм 1,5х3,0 м.кв", "TEZ0358", "м2", "кг");

	public static CustomConst lystStalnyj80 = new CustomConst("Лист ст3 8мм, м2", 2013.0, "Лист ст г/к 8мм 1,5х6,0 м.кв", "34438KP1", "Лист ст г/к 8мм 1,5х4,0 м.кв", "TEZ0361", "м2", "кг");

	public static CustomConst soplo60A = new CustomConst("Сопло 60А, шт", 79.0, "Сопло 60А арт. 120931", "34632KP1", "Сопло 60А арт. 120931", "TEZ0208", "шт", "");

	public static CustomConst electrod40_80A = new CustomConst("Електрод 40-80А, шт", 111.0, "Електроди 40-80А арт. 120926", "34630KP1", "Електроди 40-80А арт. 120926", "TEZ0092", "шт", "");

	public static CustomConst pharbaKG = new CustomConst("Фарба, кг", 64.8, "Фарба порошкова RAL 9016 глянц", "38723KP1", "Фарба НЦ-132 св/сіра 0,9кг", "TEZ0478", "шт", "");

	public static CustomConst lystStalnyj100 = new CustomConst("Лист ст3 10мм, м2", 2580.0, "Лист ст г/к 10мм 1,5х6,0 м.кв", "31079KP1", "Лист ст г/к 10мм 1,5х6,0 м.кв", "TEZ0328", "м2", "кг");

	public static CustomConst boltM8x25 = new CustomConst("Болт М8х25, шт", 1.31256, "Болт М8х25 п/всій довж, шт.", "109KP1", "Болт М8х25 п/всій довж", "TEZ0147", "шт", "");

	public static CustomConst shajbaGroverF8 = new CustomConst("Шайба гровер ф8, шт", 0.15888, "Шайба гровер оц ф8 (1кг=620шт.), шт.", "32925KP1", "Шайба гровер оц ф8 (1кг=620шт.), шт.", "TEZ0550", "шт", "");

	public static CustomConst zaklepkaKombinov4x10 = new CustomConst("Заклепка комбінована 4х10, шт", 0.28497, "Заклепка алюмінієва 4х10", "49393KP1", "Заклепка алюмінієва 4х10", "TEZ0666", "шт", "");

	public static CustomConst nonExistentMaterial = new CustomConst("Неіснуючий матеріал", 0.0, "Неіснуючий матеріал", "3", "Неіснуючий матеріал", "TEZ0000", "", "");

	public static CustomConst plytaVognezachysnaTECBOR = new CustomConst("Плита вогнезахисна TECBOR B, м2", 780.0, "Плита вогнезахисна TECBOR м2", "100806KP1", "Вогнезахисна плита", "TEZ0041", "м2", "");

	public static CustomConst kysen = new CustomConst("Кисень , шт", 342.0, "Кисень І сорт (заправка)", "87406KP1", "Кисень газ техн.бал 0,0065 2.1 (5.1)", "TEZ0131", "м2", "");

	public static CustomConst shajba16 = new CustomConst("Шайба Ø16мм, шт", 0.88044, "Шайба 16 (1кг=88 шт.)", "23314KP1", "Шайба 16 (1кг=88 шт.)", "TEZ0326", "шт", "");

	public static CustomConst hermetykTermostijkyj = new CustomConst("Герметик термостійкий, шт", 103.0, "Герметик термостійний", "55446KP1", "Герметик універсал", "TEZ0289", "шт", "");

	public static CustomConst hvynt3x16 = new CustomConst("Гвинт М3х16, шт", 0.00757844652090866, "Гвинт М3х16, шт.", "30559KP1", "Гвинт М3х16, шт.", "TEZ0260", "шт", "");

	public static CustomConst hajkaM3 = new CustomConst("Гайка М3, шт.", 0.0194693122289848, "Гайка М3 (1кг=2941шт.), шт.", "18116KP1", "Гайка М3 (1кг=2941шт.), шт.", "TEZ0227", "шт", "");

	public static CustomConst providPVS3x075 = new CustomConst("Провід ПВС 3х0,75, м.п.", 6.0, "Провід ПВС 3х0.75", "52657KP1", "Провід ПВС 3х0.75 1м", "TEZ0228", "пог. м", "");

	public static CustomConst nakonechnykTrubchastyj = new CustomConst("Наконечники трубчаті НТ 0,75-08, шт.", 0.350399399275839, "Кабельний наконечник трубч. На 2 проводи", "37428KP1", "Кабельний наконечник трубч. На 2 проводи", "TEZ0727", "шт", "");

	public static CustomConst konector125_250 = new CustomConst("Конектори FDFNY 1,25-250, шт.", 1.9632, "Коннектор пласт 3/4", "75547KP1", "", "TE0000", "шт", "");

	public static CustomConst microvymykachV_15_51C25 = new CustomConst("Мікровимикач V-15-51C25, шт.", 11.0, "Мікровимикач V-15-51C25 Аско", "85267KP1", "", "TE0000", "шт", "");

	public static CustomConst hachokM4x60 = new CustomConst("Гачок м4х60, шт", 3.7788, "Гвинт М4х40 Zn з L-подібним гачкомTN1310", "102748KP1", "", "TE0000", "шт", "");

	public static CustomConst hajkaM4 = new CustomConst("Гайка М4, шт", 0.00275194325320693, "Гайка М4 (1кг=1470шт.), шт.", "16745KP1", "Гайка М4 (1кг=1470шт.)", "TEZ0229", "шт", "");

	public static CustomConst boltM6_65 = new CustomConst("Болт М6х65, шт", 0.93228, "Болт М6х65 (1кг=70шт.), шт.", "66226KP1", "Болт М6х70 (1кг=60шт.), шт.", "TEZ0141", "шт", "");

	public static CustomConst pruzyna35 = new CustomConst("Пружина дм 3,5 мм", 24.0, "Пружина КР 004 -дм3.5мм", "91834KP1", "Пружина дм4мм", "TEZ0238", "шт", "");

	public static CustomConst zaklepkaKombinov48x6 = new CustomConst("Заклепка комбінов 4,8х6", 0.53352, "Заклепка комбінов 4,8х6", "98022KP1", "Заклепка 4,8х6", "TEZ0113", "шт", "");

	public static CustomConst profilS20nerzh = new CustomConst("Профіль Р-20 нерж, м.п.", 76.8, "Профіль Р-20 нерж.", "50235KP1", "Вентиляційний профіль 20У н/ж", "TEZ0039", "м", "");

	public static CustomConst kutnykS20nerzh = new CustomConst("Кутник Р-20/3 нерж, шт", 3.91, "Кутник Р-20/3 нерж.", "50232KP1", "Кутник монтажний 2,5В УГМ.003 нерж.", "TEZ0615", "шт", "");

	public static CustomConst profilAlumOdnor = new CustomConst("Профіль алюмінієвий №3083 м.пог", 42.9299881323057, "Профіль алюмінієвий №3083 м.пог", "121203KP1", "Профіль алюмінієвий №3083 м.пог", "TEZ1234", "пог. м", "кг");

	public static CustomConst profilAlumOdnorAnodovan = new CustomConst("Профіль алюмінієвий №3083 анодований м.пог", 57.9301232684675, "Профіль алюмінієвий №3083 анодований м.пог", "123453KP1", "Профіль алюмінієвий №3083 анодований м.пог", "TEZ1234", "пог. м", "кг");

	public static CustomConst profilAlum3319 = new CustomConst("Профіль алюмінієвий №3319 м.пог", 1.0, "Профіль алюмінієвий №3319 м.пог", "", "Профіль алюмінієвий №3319 м.пог", "", "пог. м", "кг");

	public static CustomConst profilAlumDvor = new CustomConst("Профіль алюмінієвий №3084 м.пог", 59.0965828010949, "Профіль алюмінієвий №3084 м.пог", "121204KP1", "Профіль алюмінієвий №3084 м.пог", "TEZ1235", "пог. м", "кг");

	public static CustomConst profilAlumDvorAnodovan = new CustomConst("Профіль алюмінієвий №3084 анодований м.пог", 80.552290999348, "Профіль алюмінієвий №3084 анодований м.пог", "123454KP1", "Профіль алюмінієвий №3084 анодований м.пог", "TEZ1235", "пог. м", "кг");

	public static CustomConst profilAlumLamel = new CustomConst("Профіль алюмінієвий №3085 м.пог", 20.1608811261731, "Профіль алюмінієвий №3085 м.пог", "121205KP1", "Профіль алюмінієвий №3085 м.пог", "TEZ1236", "пог. м", "кг");

	public static CustomConst profilAlumLamel3320 = new CustomConst("Профіль алюмінієвий №3320 м.пог", 1.0, "Профіль алюмінієвий №3320 м.пог", "", "Профіль алюмінієвий №3320 м.пог", "", "пог. м", "кг");

	public static CustomConst profilAlumLamelAnodovan = new CustomConst("Профіль алюмінієвий №3085 анодований м.пог", 27.335958677899, "Профіль алюмінієвий №3085 анодований м.пог", "123455KP1", "Профіль алюмінієвий №3085 анодований м.пог", "TEZ1236", "пог. м", "кг");

	public static CustomConst progilAlumBPO = new CustomConst("Профіль алюмінієвий БПО-1638 м.пог", 68.004, "Профіль алюмінієвий БПО-1638 м.пог", "126155KP1", "Профіль алюмінієвий БПО-1638 м.пог", "TEZ2233", "пог. м", "кг");

	public static CustomConst progilAlumBPOAnodovan = new CustomConst("Профіль алюмінієвий БПО-1638 анодований м.пог", 87.996, "Профіль алюмінієвий БПО-1638 анодований м.пог", "126156KP1", "Профіль алюмінієвий БПО-1638 анодований м.пог", "TEZ2244", "пог. м", "кг");

	public static CustomConst dritAlumLamel = new CustomConst("Дріт н/ж для звар апарат ф1.0мм", 489.6, "Дріт н/ж для звар апарат ф1.0мм", "57595KP1", "Дріт н/ж для звар апарат ф1.0мм", "TEZ1237", "кг", "");

	public static CustomConst lystOchynkovanyjKutnyk = new CustomConst("Лист оцинкований 1,4 м.кв.", 590.4, "Лист оцинкований 1,4 м.кв.", "41689KP1", "Лист оцинкований 1,4 м.кв.", "TEZ1238", "м2", "кг");

	public static CustomConst lystStalnyjKlipsa = new CustomConst("Лист ст  65Г 0,5 1,0х2,0 м.кв.", 816.0, "Лист ст  65Г 0,5 1,0х2,0 м.кв.", "119707KP1", "Лист ст  65Г 0,5 1,0х2,0 м.кв.", "TEZ1239", "м2", "");

	public static CustomConst kysen1sort = new CustomConst("Кисень І сорт (заправка)", 648.0, "Кисень І сорт (заправка)", "87406KP1", "Кисень І сорт (заправка)", "TEZ1240", "шт", "");

	public static CustomConst gvynt35 = new CustomConst("Гвинт 3.5х25 ТЕХ-С цб пот PH", 0.39, "Гвинт 3.5х25 ТЕХ-С цб пот PH", "127206KP1", "Гвинт 3.5х25 ТЕХ-С цб пот PH", "TEZ0729", "шт", "");

	public static CustomConst zatyscach = new CustomConst("Затискач, шт", 0.144, "Затискач, шт", "40208KP1", "Затискач, шт", "TEZ0730", "шт", "");

	public static CustomConst kutnykReshVent = new CustomConst("Кутник (1,2 мм) оц, шт", 2.589291799742819, "Кутник (1,2 мм) оц", "121KP1", "Кутник (1,2 мм) оц", "TEZ01221", "шт", "");

	public static CustomConst klipsaReshVent = new CustomConst("Кліпса C, шт", 4.589291799742819, "Кліпса C", "122KP1", "Кліпса C", "TEZ01222", "шт", "");

	public static CustomConst sitka10x10 = new CustomConst("Сітка 10х10, м2", 1.0, "Сітка 10х10, м2", "", "Сітка 10х10, м2", "", "м2", "");

	public static CustomConst farba9016W = new CustomConst("Фарба порошкова PE54AT 9016 189GLX", 223.8, "Фарба порошкова PE54AT 9016 189GLX", "42803KP1", "Фарба порошкова PE54AT 9016 189GLX", "TEZ0466", "кг", "");

	public static CustomConst farba9016WM = new CustomConst("Фарба 9016М Білий матовий", 65.0, "Фарба 9016М Білий матовий", "11150KP1", "Фарба 9016М Білий матовий", "TEZ0467", "шт", "");

	public static CustomConst farba9005B = new CustomConst("Фарба 9005 Чорний", 65.0, "Фарба 9005 Чорний", "11151KP1", "Фарба 9005 Чорний", "TEZ0468", "шт", "");

	public static CustomConst farba9005BM = new CustomConst("Фарба 9005М Чорний матовий", 65.0, "Фарба 9005М Чорний матовий", "11152KP1", "Фарба 9005М Чорний матовий", "TEZ0469", "шт", "");

	public static CustomConst farba9001 = new CustomConst("Фарба 9001", 65.0, "Фарба 9001", "11153KP1", "Фарба 9001", "TEZ0470", "шт", "");

	public static CustomConst farba9001M = new CustomConst("Фарба 9001М", 65.0, "Фарба 9001М", "11154KP1", "Фарба 9001М", "TEZ0471", "шт", "");

	public static CustomConst farba9002 = new CustomConst("Фарба 9002", 65.0, "Фарба 9002", "11155KP1", "Фарба 9002", "TEZ0472", "шт", "");

	public static CustomConst farba9002M = new CustomConst("Фарба 9002М", 65.0, "Фарба 9002М", "11156KP1", "Фарба 9002М", "TEZ0473", "шт", "");

	public static CustomConst farba9003 = new CustomConst("Фарба 9003", 65.0, "Фарба 9003", "11157KP1", "Фарба 9003", "TEZ0474", "шт", "");

	public static CustomConst farba9003M = new CustomConst("Фарба  9003М", 65.0, "Фарба  9003М", "11158KP1", "Фарба  9003М", "TEZ0475", "шт", "");

	public static CustomConst farba9010 = new CustomConst("Фарба 9010", 65.0, "Фарба 9010", "11159KP1", "Фарба 9010", "TEZ0476", "шт", "");

	public static CustomConst farba9010M = new CustomConst("Фарба 9010М", 65.0, "Фарба 9010М", "11160KP1", "Фарба 9010М", "TEZ0477", "шт", "");

	public static CustomConst farba9004 = new CustomConst("Фарба 9004", 65.0, "Фарба 9004", "11163KP1", "Фарба 9004", "TEZ0480", "шт", "");

	public static CustomConst farba9004M = new CustomConst("Фарба 9004М", 65.0, "Фарба 9004М", "11164KP1", "Фарба 9004М", "TEZ0481", "шт", "");

	public static CustomConst farba90011 = new CustomConst("Фарба 90011", 65.0, "Фарба 90011", "11165KP1", "Фарба 90011", "TEZ0482", "шт", "");

	public static CustomConst farba90011M = new CustomConst("Фарба 90011М", 65.0, "Фарба 90011М", "11166KP1", "Фарба 90011М", "TEZ0483", "шт", "");

	public static CustomConst farba90017 = new CustomConst("Фарба 90017", 65.0, "Фарба 90017", "11167KP1", "Фарба 90017", "TEZ0484", "шт", "");

	public static CustomConst farba90017M = new CustomConst("Фарба 90017М", 65.0, "Фарба 90017М", "11168KP1", "Фарба 90017М", "TEZ0485", "шт", "");

	public static CustomConst farba1000 = new CustomConst("Фарба 1000", 65.0, "Фарба 1000", "11170KP1", "Фарба 1000", "TEZ0487", "шт", "");

	public static CustomConst farba1001 = new CustomConst("Фарба 1001", 65.0, "Фарба 1001", "11171KP1", "Фарба 1001", "TEZ0488", "шт", "");

	public static CustomConst farba1001M = new CustomConst("Фарба 1001М", 65.0, "Фарба 1001М", "11172KP1", "Фарба 1001М", "TEZ0489", "шт", "");

	public static CustomConst farba1002 = new CustomConst("Фарба 1002", 65.0, "Фарба 1002", "11173KP1", "Фарба 1002", "TEZ0490", "шт", "");

	public static CustomConst farba1003 = new CustomConst("Фарба 1003", 65.0, "Фарба 1003", "11174KP1", "Фарба 1003", "TEZ0491", "шт", "");

	public static CustomConst farba1004 = new CustomConst("Фарба 1004", 65.0, "Фарба 1004", "11175KP1", "Фарба 1004", "TEZ0492", "шт", "");

	public static CustomConst farba1005 = new CustomConst("Фарба 1005", 65.0, "Фарба 1005", "11176KP1", "Фарба 1005", "TEZ0493", "шт", "");

	public static CustomConst farba1005M = new CustomConst("Фарба 1005М", 65.0, "Фарба 1005М", "11177KP1", "Фарба 1005М", "TEZ0494", "шт", "");

	public static CustomConst farba1007 = new CustomConst("Фарба 1007", 65.0, "Фарба 1007", "11178KP1", "Фарба 1007", "TEZ0495", "шт", "");

	public static CustomConst farba1011 = new CustomConst("Фарба 1011", 65.0, "Фарба 1011", "11179KP1", "Фарба 1011", "TEZ0496", "шт", "");

	public static CustomConst farba1011M = new CustomConst("Фарба 1011М", 65.0, "Фарба 1011М", "11180KP1", "Фарба 1011М", "TEZ0497", "шт", "");

	public static CustomConst farba1012 = new CustomConst("Фарба 1012", 65.0, "Фарба 1012", "11181KP1", "Фарба 1012", "TEZ0498", "шт", "");

	public static CustomConst farba1013 = new CustomConst("Фарба 1013", 65.0, "Фарба 1013", "11182KP1", "Фарба 1013", "TEZ0499", "шт", "");

	public static CustomConst farba1013M = new CustomConst("Фарба 1013М", 65.0, "Фарба 1013М", "11183KP1", "Фарба 1013М", "TEZ0500", "шт", "");

	public static CustomConst farba1014 = new CustomConst("Фарба 1014", 65.0, "Фарба 1014", "11184KP1", "Фарба 1014", "TEZ0501", "шт", "");

	public static CustomConst farba1014M = new CustomConst("Фарба 1014М", 65.0, "Фарба 1014М", "11185KP1", "Фарба 1014М", "TEZ0502", "шт", "");

	public static CustomConst farba1015 = new CustomConst("Фарба 1015", 65.0, "Фарба 1015", "11186KP1", "Фарба 1015", "TEZ0503", "шт", "");

	public static CustomConst farba1015M = new CustomConst("Фарба 1015М", 65.0, "Фарба 1015М", "11187KP1", "Фарба 1015М", "TEZ0504", "шт", "");

	public static CustomConst farba1016 = new CustomConst("Фарба 1016", 65.0, "Фарба 1016", "11188KP1", "Фарба 1016", "TEZ0505", "шт", "");

	public static CustomConst farba1017 = new CustomConst("Фарба 1017", 65.0, "Фарба 1017", "11189KP1", "Фарба 1017", "TEZ0506", "шт", "");

	public static CustomConst farba1018 = new CustomConst("Фарба 1018", 65.0, "Фарба 1018", "11190KP1", "Фарба 1018", "TEZ0507", "шт", "");

	public static CustomConst farba1019 = new CustomConst("Фарба 1019", 65.0, "Фарба 1019", "11191KP1", "Фарба 1019", "TEZ0508", "шт", "");

	public static CustomConst farba1019M = new CustomConst("Фарба 1019М", 65.0, "Фарба 1019М", "11192KP1", "Фарба 1019М", "TEZ0509", "шт", "");

	public static CustomConst farba1020 = new CustomConst("Фарба 1020", 65.0, "Фарба 1020", "11193KP1", "Фарба 1020", "TEZ0510", "шт", "");

	public static CustomConst farba1021 = new CustomConst("Фарба 1021", 65.0, "Фарба 1021", "11194KP1", "Фарба 1021", "TEZ0511", "шт", "");

	public static CustomConst farba1021M = new CustomConst("Фарба 1021М", 65.0, "Фарба 1021М", "11195KP1", "Фарба 1021М", "TEZ0512", "шт", "");

	public static CustomConst farba1023 = new CustomConst("Фарба 1023", 65.0, "Фарба 1023", "11196KP1", "Фарба 1023", "TEZ0513", "шт", "");

	public static CustomConst farba1023M = new CustomConst("Фарба 1023М", 65.0, "Фарба 1023М", "11197KP1", "Фарба 1023М", "TEZ0514", "шт", "");

	public static CustomConst farba1024 = new CustomConst("Фарба 1024", 65.0, "Фарба 1024", "11198KP1", "Фарба 1024", "TEZ0515", "шт", "");

	public static CustomConst farba1026 = new CustomConst("Фарба 1026", 65.0, "Фарба 1026", "11199KP1", "Фарба 1026", "TEZ0516", "шт", "");

	public static CustomConst farba1027 = new CustomConst("Фарба 1027", 65.0, "Фарба 1027", "11200KP1", "Фарба 1027", "TEZ0517", "шт", "");

	public static CustomConst farba1028 = new CustomConst("Фарба 1028", 65.0, "Фарба 1028", "11201KP1", "Фарба 1028", "TEZ0518", "шт", "");

	public static CustomConst farba1032 = new CustomConst("Фарба 1032", 65.0, "Фарба 1032", "11202KP1", "Фарба 1032", "TEZ0519", "шт", "");

	public static CustomConst farba1033 = new CustomConst("Фарба 1033", 65.0, "Фарба 1033", "11203KP1", "Фарба 1033", "TEZ0520", "шт", "");

	public static CustomConst farba1034 = new CustomConst("Фарба 1034", 65.0, "Фарба 1034", "11204KP1", "Фарба 1034", "TEZ0521", "шт", "");

	public static CustomConst farba1035 = new CustomConst("Фарба 1035", 65.0, "Фарба 1035", "11205KP1", "Фарба 1035", "TEZ0522", "шт", "");

	public static CustomConst farba1036 = new CustomConst("Фарба 1036", 65.0, "Фарба 1036", "11206KP1", "Фарба 1036", "TEZ0523", "шт", "");

	public static CustomConst farba1036M = new CustomConst("Фарба 1036М", 65.0, "Фарба 1036М", "11207KP1", "Фарба 1036М", "TEZ0524", "шт", "");

	public static CustomConst farba1037 = new CustomConst("Фарба 1037", 65.0, "Фарба 1037", "11208KP1", "Фарба 1037", "TEZ0525", "шт", "");

	public static CustomConst farba2000 = new CustomConst("Фарба 2000", 65.0, "Фарба 2000", "11209KP1", "Фарба 2000", "TEZ0526", "шт", "");

	public static CustomConst farba2001 = new CustomConst("Фарба 2001", 65.0, "Фарба 2001", "11210KP1", "Фарба 2001", "TEZ0527", "шт", "");

	public static CustomConst farba2002 = new CustomConst("Фарба 2002", 65.0, "Фарба 2002", "11211KP1", "Фарба 2002", "TEZ0528", "шт", "");

	public static CustomConst farba2003 = new CustomConst("Фарба 2003", 65.0, "Фарба 2003", "11212KP1", "Фарба 2003", "TEZ0529", "шт", "");

	public static CustomConst farba2004 = new CustomConst("Фарба 2004", 65.0, "Фарба 2004", "11213KP1", "Фарба 2004", "TEZ0530", "шт", "");

	public static CustomConst farba2008 = new CustomConst("Фарба 2008", 65.0, "Фарба 2008", "11214KP1", "Фарба 2008", "TEZ0531", "шт", "");

	public static CustomConst farba2009 = new CustomConst("Фарба 2009", 65.0, "Фарба 2009", "11215KP1", "Фарба 2009", "TEZ0532", "шт", "");

	public static CustomConst farba2010 = new CustomConst("Фарба 2010", 65.0, "Фарба 2010", "11216KP1", "Фарба 2010", "TEZ0533", "шт", "");

	public static CustomConst farba2011 = new CustomConst("Фарба 2011", 65.0, "Фарба 2011", "11217KP1", "Фарба 2011", "TEZ0534", "шт", "");

	public static CustomConst farba2012 = new CustomConst("Фарба 2012", 65.0, "Фарба 2012", "11218KP1", "Фарба 2012", "TEZ0535", "шт", "");

	public static CustomConst farba2013 = new CustomConst("Фарба 2013", 65.0, "Фарба 2013", "11219KP1", "Фарба 2013", "TEZ0536", "шт", "");

	public static CustomConst farba3000 = new CustomConst("Фарба 3000", 65.0, "Фарба 3000", "11220KP1", "Фарба 3000", "TEZ0537", "шт", "");

	public static CustomConst farba3001 = new CustomConst("Фарба 3001", 65.0, "Фарба 3001", "11221KP1", "Фарба 3001", "TEZ0538", "шт", "");

	public static CustomConst farba3002 = new CustomConst("Фарба 3002", 65.0, "Фарба 3002", "11222KP1", "Фарба 3002", "TEZ0539", "шт", "");

	public static CustomConst farba3003 = new CustomConst("Фарба 3003", 65.0, "Фарба 3003", "11223KP1", "Фарба 3003", "TEZ0540", "шт", "");

	public static CustomConst farba3004 = new CustomConst("Фарба 3004", 65.0, "Фарба 3004", "11224KP1", "Фарба 3004", "TEZ0541", "шт", "");

	public static CustomConst farba3005 = new CustomConst("Фарба 3005", 65.0, "Фарба 3005", "11225KP1", "Фарба 3005", "TEZ0542", "шт", "");

	public static CustomConst farba3005M = new CustomConst("Фарба 3005М", 65.0, "Фарба 3005М", "11226KP1", "Фарба 3005М", "TEZ0543", "шт", "");

	public static CustomConst farba3007 = new CustomConst("Фарба 3007", 65.0, "Фарба 3007", "11227KP1", "Фарба 3007", "TEZ0544", "шт", "");

	public static CustomConst farba3009 = new CustomConst("Фарба 3009", 65.0, "Фарба 3009", "11228KP1", "Фарба 3009", "TEZ0545", "шт", "");

	public static CustomConst farba3011 = new CustomConst("Фарба 3011", 65.0, "Фарба 3011", "11229KP1", "Фарба 3011", "TEZ0546", "шт", "");

	public static CustomConst farba3012 = new CustomConst("Фарба 3012", 65.0, "Фарба 3012", "11230KP1", "Фарба 3012", "TEZ0547", "шт", "");

	public static CustomConst farba3013 = new CustomConst("Фарба 3013", 65.0, "Фарба 3013", "11231KP1", "Фарба 3013", "TEZ0548", "шт", "");

	public static CustomConst farba3014 = new CustomConst("Фарба 3014", 65.0, "Фарба 3014", "11232KP1", "Фарба 3014", "TEZ0549", "шт", "");

	public static CustomConst farba3015 = new CustomConst("Фарба 3015", 65.0, "Фарба 3015", "11233KP1", "Фарба 3015", "TEZ0550", "шт", "");

	public static CustomConst farba3016 = new CustomConst("Фарба 3016", 65.0, "Фарба 3016", "11234KP1", "Фарба 3016", "TEZ0551", "шт", "");

	public static CustomConst farba3017 = new CustomConst("Фарба 3017", 65.0, "Фарба 3017", "11235KP1", "Фарба 3017", "TEZ0552", "шт", "");

	public static CustomConst farba3018 = new CustomConst("Фарба 3018", 65.0, "Фарба 3018", "11236KP1", "Фарба 3018", "TEZ0553", "шт", "");

	public static CustomConst farba3020 = new CustomConst("Фарба 3020", 65.0, "Фарба 3020", "11237KP1", "Фарба 3020", "TEZ0554", "шт", "");

	public static CustomConst farba3022 = new CustomConst("Фарба 3022", 65.0, "Фарба 3022", "11238KP1", "Фарба 3022", "TEZ0555", "шт", "");

	public static CustomConst farba3028 = new CustomConst("Фарба 3028", 65.0, "Фарба 3028", "11239KP1", "Фарба 3028", "TEZ0556", "шт", "");

	public static CustomConst farba3031 = new CustomConst("Фарба 3031", 65.0, "Фарба 3031", "11240KP1", "Фарба 3031", "TEZ0557", "шт", "");

	public static CustomConst farba3033 = new CustomConst("Фарба 3033", 65.0, "Фарба 3033", "11241KP1", "Фарба 3033", "TEZ0558", "шт", "");

	public static CustomConst farba4002 = new CustomConst("Фарба 4002", 65.0, "Фарба 4002", "11242KP1", "Фарба 4002", "TEZ0559", "шт", "");

	public static CustomConst farba4003 = new CustomConst("Фарба 4003", 65.0, "Фарба 4003", "11243KP1", "Фарба 4003", "TEZ0560", "шт", "");

	public static CustomConst farba4004 = new CustomConst("Фарба 4004", 65.0, "Фарба 4004", "11244KP1", "Фарба 4004", "TEZ0561", "шт", "");

	public static CustomConst farba4005 = new CustomConst("Фарба 4005", 65.0, "Фарба 4005", "11245KP1", "Фарба 4005", "TEZ0562", "шт", "");

	public static CustomConst farba4007 = new CustomConst("Фарба 4007", 65.0, "Фарба 4007", "11246KP1", "Фарба 4007", "TEZ0563", "шт", "");

	public static CustomConst farba4009 = new CustomConst("Фарба 4009", 65.0, "Фарба 4009", "11247KP1", "Фарба 4009", "TEZ0564", "шт", "");

	public static CustomConst farba4011 = new CustomConst("Фарба 4011", 65.0, "Фарба 4011", "11248KP1", "Фарба 4011", "TEZ0565", "шт", "");

	public static CustomConst farba5000 = new CustomConst("Фарба 5000", 65.0, "Фарба 5000", "11249KP1", "Фарба 5000", "TEZ0566", "шт", "");

	public static CustomConst farba5001 = new CustomConst("Фарба 5001", 65.0, "Фарба 5001", "11250KP1", "Фарба 5001", "TEZ0567", "шт", "");

	public static CustomConst farba5001M = new CustomConst("Фарба 5001М", 65.0, "Фарба 5001М", "11251KP1", "Фарба 5001М", "TEZ0568", "шт", "");

	public static CustomConst farba5002 = new CustomConst("Фарба 5002", 65.0, "Фарба 5002", "11252KP1", "Фарба 5002", "TEZ0569", "шт", "");

	public static CustomConst farba5003 = new CustomConst("Фарба 5003", 65.0, "Фарба 5003", "11253KP1", "Фарба 5003", "TEZ0570", "шт", "");

	public static CustomConst farba5003M = new CustomConst("Фарба 5003М", 65.0, "Фарба 5003М", "11254KP1", "Фарба 5003М", "TEZ0571", "шт", "");

	public static CustomConst farba5004 = new CustomConst("Фарба 5004", 65.0, "Фарба 5004", "11255KP1", "Фарба 5004", "TEZ0572", "шт", "");

	public static CustomConst farba5005 = new CustomConst("Фарба 5005", 65.0, "Фарба 5005", "11256KP1", "Фарба 5005", "TEZ0573", "шт", "");

	public static CustomConst farba5007 = new CustomConst("Фарба 5007", 65.0, "Фарба 5007", "11257KP1", "Фарба 5007", "TEZ0574", "шт", "");

	public static CustomConst farba5008 = new CustomConst("Фарба 5008", 65.0, "Фарба 5008", "11258KP1", "Фарба 5008", "TEZ0575", "шт", "");

	public static CustomConst farba5009 = new CustomConst("Фарба 5009", 65.0, "Фарба 5009", "11259KP1", "Фарба 5009", "TEZ0576", "шт", "");

	public static CustomConst farba5010 = new CustomConst("Фарба 5010", 65.0, "Фарба 5010", "11260KP1", "Фарба 5010", "TEZ0577", "шт", "");

	public static CustomConst farba5011 = new CustomConst("Фарба 5011", 65.0, "Фарба 5011", "11261KP1", "Фарба 5011", "TEZ0578", "шт", "");

	public static CustomConst farba5012 = new CustomConst("Фарба 5012", 65.0, "Фарба 5012", "11262KP1", "Фарба 5012", "TEZ0579", "шт", "");

	public static CustomConst farba5013 = new CustomConst("Фарба 5013", 65.0, "Фарба 5013", "11263KP1", "Фарба 5013", "TEZ0580", "шт", "");

	public static CustomConst farba5013M = new CustomConst("Фарба 5013М", 65.0, "Фарба 5013М", "11264KP1", "Фарба 5013М", "TEZ0581", "шт", "");

	public static CustomConst farba5014 = new CustomConst("Фарба 5014", 65.0, "Фарба 5014", "11265KP1", "Фарба 5014", "TEZ0582", "шт", "");

	public static CustomConst farba5015 = new CustomConst("Фарба 5015", 65.0, "Фарба 5015", "11266KP1", "Фарба 5015", "TEZ0583", "шт", "");

	public static CustomConst farba5017 = new CustomConst("Фарба 5017", 65.0, "Фарба 5017", "11267KP1", "Фарба 5017", "TEZ0584", "шт", "");

	public static CustomConst farba5018 = new CustomConst("Фарба 5018", 65.0, "Фарба 5018", "11268KP1", "Фарба 5018", "TEZ0585", "шт", "");

	public static CustomConst farba5019 = new CustomConst("Фарба 5019", 65.0, "Фарба 5019", "11269KP1", "Фарба 5019", "TEZ0586", "шт", "");

	public static CustomConst farba5020 = new CustomConst("Фарба 5020", 65.0, "Фарба 5020", "11270KP1", "Фарба 5020", "TEZ0587", "шт", "");

	public static CustomConst farba5021 = new CustomConst("Фарба 5021", 65.0, "Фарба 5021", "11271KP1", "Фарба 5021", "TEZ0588", "шт", "");

	public static CustomConst farba5022 = new CustomConst("Фарба 5022", 65.0, "Фарба 5022", "11272KP1", "Фарба 5022", "TEZ0589", "шт", "");

	public static CustomConst farba5023 = new CustomConst("Фарба 5023", 65.0, "Фарба 5023", "11273KP1", "Фарба 5023", "TEZ0590", "шт", "");

	public static CustomConst farba5023M = new CustomConst("Фарба 5023М", 65.0, "Фарба 5023М", "11274KP1", "Фарба 5023М", "TEZ0591", "шт", "");

	public static CustomConst farba5024 = new CustomConst("Фарба 5024", 65.0, "Фарба 5024", "11275KP1", "Фарба 5024", "TEZ0592", "шт", "");

	public static CustomConst farba5025 = new CustomConst("Фарба 5025", 65.0, "Фарба 5025", "11276KP1", "Фарба 5025", "TEZ0593", "шт", "");

	public static CustomConst farba5026 = new CustomConst("Фарба 5026", 65.0, "Фарба 5026", "11277KP1", "Фарба 5026", "TEZ0594", "шт", "");

	public static CustomConst farba6000 = new CustomConst("Фарба 6000", 65.0, "Фарба 6000", "11278KP1", "Фарба 6000", "TEZ0595", "шт", "");

	public static CustomConst farba6001 = new CustomConst("Фарба 6001", 65.0, "Фарба 6001", "11279KP1", "Фарба 6001", "TEZ0596", "шт", "");

	public static CustomConst farba6002 = new CustomConst("Фарба 6002", 65.0, "Фарба 6002", "11280KP1", "Фарба 6002", "TEZ0597", "шт", "");

	public static CustomConst farba6003 = new CustomConst("Фарба 6003", 65.0, "Фарба 6003", "11281KP1", "Фарба 6003", "TEZ0598", "шт", "");

	public static CustomConst farba6003M = new CustomConst("Фарба 6003М", 65.0, "Фарба 6003М", "11282KP1", "Фарба 6003М", "TEZ0599", "шт", "");

	public static CustomConst farba6004 = new CustomConst("Фарба 6004", 65.0, "Фарба 6004", "11283KP1", "Фарба 6004", "TEZ0600", "шт", "");

	public static CustomConst farba6004M = new CustomConst("Фарба 6004М", 65.0, "Фарба 6004М", "11284KP1", "Фарба 6004М", "TEZ0601", "шт", "");

	public static CustomConst farba6005 = new CustomConst("Фарба 6005", 65.0, "Фарба 6005", "11285KP1", "Фарба 6005", "TEZ0602", "шт", "");

	public static CustomConst farba6005M = new CustomConst("Фарба 6005М", 65.0, "Фарба 6005М", "11286KP1", "Фарба 6005М", "TEZ0603", "шт", "");

	public static CustomConst farba6006 = new CustomConst("Фарба 6006", 65.0, "Фарба 6006", "11287KP1", "Фарба 6006", "TEZ0604", "шт", "");

	public static CustomConst farba6007 = new CustomConst("Фарба 6007", 65.0, "Фарба 6007", "11288KP1", "Фарба 6007", "TEZ0605", "шт", "");

	public static CustomConst farba6009 = new CustomConst("Фарба 6009", 65.0, "Фарба 6009", "11289KP1", "Фарба 6009", "TEZ0606", "шт", "");

	public static CustomConst farba6010 = new CustomConst("Фарба 6010", 65.0, "Фарба 6010", "11290KP1", "Фарба 6010", "TEZ0607", "шт", "");

	public static CustomConst farba6011 = new CustomConst("Фарба 6011", 65.0, "Фарба 6011", "11291KP1", "Фарба 6011", "TEZ0608", "шт", "");

	public static CustomConst farba6012 = new CustomConst("Фарба 6012", 65.0, "Фарба 6012", "11292KP1", "Фарба 6012", "TEZ0609", "шт", "");

	public static CustomConst farba6013 = new CustomConst("Фарба 6013", 65.0, "Фарба 6013", "11293KP1", "Фарба 6013", "TEZ0610", "шт", "");

	public static CustomConst farba6014 = new CustomConst("Фарба 6014", 65.0, "Фарба 6014", "11294KP1", "Фарба 6014", "TEZ0611", "шт", "");

	public static CustomConst farba6015 = new CustomConst("Фарба 6015", 65.0, "Фарба 6015", "11295KP1", "Фарба 6015", "TEZ0612", "шт", "");

	public static CustomConst farba6016 = new CustomConst("Фарба 6016", 65.0, "Фарба 6016", "11296KP1", "Фарба 6016", "TEZ0613", "шт", "");

	public static CustomConst farba6017 = new CustomConst("Фарба 6017", 65.0, "Фарба 6017", "11297KP1", "Фарба 6017", "TEZ0614", "шт", "");

	public static CustomConst farba6018 = new CustomConst("Фарба 6018", 65.0, "Фарба 6018", "11298KP1", "Фарба 6018", "TEZ0615", "шт", "");

	public static CustomConst farba6019 = new CustomConst("Фарба 6019", 65.0, "Фарба 6019", "11299KP1", "Фарба 6019", "TEZ0616", "шт", "");

	public static CustomConst farba6019M = new CustomConst("Фарба 6019М", 65.0, "Фарба 6019М", "11300KP1", "Фарба 6019М", "TEZ0617", "шт", "");

	public static CustomConst farba6020 = new CustomConst("Фарба 6020", 65.0, "Фарба 6020", "11301KP1", "Фарба 6020", "TEZ0618", "шт", "");

	public static CustomConst farba6020M = new CustomConst("Фарба 6020М", 65.0, "Фарба 6020М", "11302KP1", "Фарба 6020М", "TEZ0619", "шт", "");

	public static CustomConst farba6021 = new CustomConst("Фарба 6021", 65.0, "Фарба 6021", "11303KP1", "Фарба 6021", "TEZ0620", "шт", "");

	public static CustomConst farba6021M = new CustomConst("Фарба 6021М", 65.0, "Фарба 6021М", "11304KP1", "Фарба 6021М", "TEZ0621", "шт", "");

	public static CustomConst farba6022 = new CustomConst("Фарба 6022", 65.0, "Фарба 6022", "11305KP1", "Фарба 6022", "TEZ0622", "шт", "");

	public static CustomConst farba6024 = new CustomConst("Фарба 6024", 65.0, "Фарба 6024", "11306KP1", "Фарба 6024", "TEZ0623", "шт", "");

	public static CustomConst farba6025 = new CustomConst("Фарба 6025", 65.0, "Фарба 6025", "11307KP1", "Фарба 6025", "TEZ0624", "шт", "");

	public static CustomConst farba6026 = new CustomConst("Фарба 6026", 65.0, "Фарба 6026", "11308KP1", "Фарба 6026", "TEZ0625", "шт", "");

	public static CustomConst farba6027 = new CustomConst("Фарба 6027", 65.0, "Фарба 6027", "11309KP1", "Фарба 6027", "TEZ0626", "шт", "");

	public static CustomConst farba6027M = new CustomConst("Фарба 6027М", 65.0, "Фарба 6027М", "11310KP1", "Фарба 6027М", "TEZ0627", "шт", "");

	public static CustomConst farba6028 = new CustomConst("Фарба 6028", 65.0, "Фарба 6028", "11311KP1", "Фарба 6028", "TEZ0628", "шт", "");

	public static CustomConst farba6029 = new CustomConst("Фарба 6029", 65.0, "Фарба 6029", "11312KP1", "Фарба 6029", "TEZ0629", "шт", "");

	public static CustomConst farba6032 = new CustomConst("Фарба 6032", 65.0, "Фарба 6032", "11313KP1", "Фарба 6032", "TEZ0630", "шт", "");

	public static CustomConst farba6033 = new CustomConst("Фарба 6033", 65.0, "Фарба 6033", "11314KP1", "Фарба 6033", "TEZ0631", "шт", "");

	public static CustomConst farba6034 = new CustomConst("Фарба 6034", 65.0, "Фарба 6034", "11315KP1", "Фарба 6034", "TEZ0632", "шт", "");

	public static CustomConst farba6034M = new CustomConst("Фарба 6034М", 65.0, "Фарба 6034М", "11316KP1", "Фарба 6034М", "TEZ0633", "шт", "");

	public static CustomConst farba6035 = new CustomConst("Фарба 6035", 65.0, "Фарба 6035", "11317KP1", "Фарба 6035", "TEZ0634", "шт", "");

	public static CustomConst farba6036 = new CustomConst("Фарба 6036", 65.0, "Фарба 6036", "11318KP1", "Фарба 6036", "TEZ0635", "шт", "");

	public static CustomConst farba6037 = new CustomConst("Фарба 6037", 65.0, "Фарба 6037", "11319KP1", "Фарба 6037", "TEZ0636", "шт", "");

	public static CustomConst farba7000 = new CustomConst("Фарба 7000", 65.0, "Фарба 7000", "11320KP1", "Фарба 7000", "TEZ0637", "шт", "");

	public static CustomConst farba7001 = new CustomConst("Фарба 7001", 65.0, "Фарба 7001", "11321KP1", "Фарба 7001", "TEZ0638", "шт", "");

	public static CustomConst farba7001M = new CustomConst("Фарба 7001М", 65.0, "Фарба 7001М", "11322KP1", "Фарба 7001М", "TEZ0639", "шт", "");

	public static CustomConst farba7002 = new CustomConst("Фарба 7002", 65.0, "Фарба 7002", "11323KP1", "Фарба 7002", "TEZ0640", "шт", "");

	public static CustomConst farba7003 = new CustomConst("Фарба 7003", 65.0, "Фарба 7003", "11324KP1", "Фарба 7003", "TEZ0641", "шт", "");

	public static CustomConst farba7004 = new CustomConst("Фарба порошкова PE58AT 7004 189 GLX", 277.8, "Фарба порошкова PE58AT 7004 189 GLX", "129290KP1", "Фарба порошкова PE58AT 7004 189 GLX", "TEZ0642", "кг", "");

	public static CustomConst farba7005 = new CustomConst("Фарба 7005", 65.0, "Фарба 7005", "11326KP1", "Фарба 7005", "TEZ0643", "шт", "");

	public static CustomConst farba7005M = new CustomConst("Фарба 7005М", 65.0, "Фарба 7005М", "11327KP1", "Фарба 7005М", "TEZ0644", "шт", "");

	public static CustomConst farba7006 = new CustomConst("Фарба 7006", 65.0, "Фарба 7006", "11328KP1", "Фарба 7006", "TEZ0645", "шт", "");

	public static CustomConst farba7006M = new CustomConst("Фарба 7006М", 65.0, "Фарба 7006М", "11329KP1", "Фарба 7006М", "TEZ0646", "шт", "");

	public static CustomConst farba7008 = new CustomConst("Фарба 7008", 65.0, "Фарба 7008", "11330KP1", "Фарба 7008", "TEZ0647", "шт", "");

	public static CustomConst farba7009 = new CustomConst("Фарба 7009", 65.0, "Фарба 7009", "11331KP1", "Фарба 7009", "TEZ0648", "шт", "");

	public static CustomConst farba7010 = new CustomConst("Фарба 7010", 65.0, "Фарба 7010", "11332KP1", "Фарба 7010", "TEZ0649", "шт", "");

	public static CustomConst farba7010M = new CustomConst("Фарба 7010М", 65.0, "Фарба 7010М", "11333KP1", "Фарба 7010М", "TEZ0650", "шт", "");

	public static CustomConst farba7011 = new CustomConst("Фарба 7011", 65.0, "Фарба 7011", "11334KP1", "Фарба 7011", "TEZ0651", "шт", "");

	public static CustomConst farba7011M = new CustomConst("Фарба 7011М", 65.0, "Фарба 7011М", "11335KP1", "Фарба 7011М", "TEZ0652", "шт", "");

	public static CustomConst farba7012 = new CustomConst("Фарба 7012", 65.0, "Фарба 7012", "11336KP1", "Фарба 7012", "TEZ0653", "шт", "");

	public static CustomConst farba7012M = new CustomConst("Фарба 7012М", 65.0, "Фарба 7012М", "11337KP1", "Фарба 7012М", "TEZ0654", "шт", "");

	public static CustomConst farba7013 = new CustomConst("Фарба 7013", 65.0, "Фарба 7013", "11338KP1", "Фарба 7013", "TEZ0655", "шт", "");

	public static CustomConst farba7015 = new CustomConst("Фарба 7015", 65.0, "Фарба 7015", "11339KP1", "Фарба 7015", "TEZ0656", "шт", "");

	public static CustomConst farba7015M = new CustomConst("Фарба 7015М", 65.0, "Фарба 7015М", "11340KP1", "Фарба 7015М", "TEZ0657", "шт", "");

	public static CustomConst farba7016 = new CustomConst("Фарба 7016", 65.0, "Фарба 7016", "11341KP1", "Фарба 7016", "TEZ0658", "шт", "");

	public static CustomConst farba7016M = new CustomConst("Фарба 7016М", 65.0, "Фарба 7016М", "11342KP1", "Фарба 7016М", "TEZ0659", "шт", "");

	public static CustomConst farba7021 = new CustomConst("Фарба 7021", 65.0, "Фарба 7021", "11343KP1", "Фарба 7021", "TEZ0660", "шт", "");

	public static CustomConst farba7021M = new CustomConst("Фарба 7021М", 65.0, "Фарба 7021М", "11344KP1", "Фарба 7021М", "TEZ0661", "шт", "");

	public static CustomConst farba7022 = new CustomConst("Фарба 7022", 65.0, "Фарба 7022", "11345KP1", "Фарба 7022", "TEZ0662", "шт", "");

	public static CustomConst farba7022M = new CustomConst("Фарба 7022М", 65.0, "Фарба 7022М", "11346KP1", "Фарба 7022М", "TEZ0663", "шт", "");

	public static CustomConst farba7023 = new CustomConst("Фарба 7023", 65.0, "Фарба 7023", "11347KP1", "Фарба 7023", "TEZ0664", "шт", "");

	public static CustomConst farba7024 = new CustomConst("Фарба 7024", 65.0, "Фарба 7024", "11348KP1", "Фарба 7024", "TEZ0665", "шт", "");

	public static CustomConst farba7024M = new CustomConst("Фарба порошкова PE55AT 7024 103CMX", 228.0, "Фарба порошкова PE55AT 7024 103CMX", "128486KP1", "Фарба порошкова PE55AT 7024 103CMX", "TEZ0666", "кг", "");

	public static CustomConst farba7026 = new CustomConst("Фарба 7026", 65.0, "Фарба 7026", "11350KP1", "Фарба 7026", "TEZ0667", "шт", "");

	public static CustomConst farba7026M = new CustomConst("Фарба 7026М", 65.0, "Фарба 7026М", "11351KP1", "Фарба 7026М", "TEZ0668", "шт", "");

	public static CustomConst farba7030 = new CustomConst("Фарба 7030", 65.0, "Фарба 7030", "11352KP1", "Фарба 7030", "TEZ0669", "шт", "");

	public static CustomConst farba7030M = new CustomConst("Фарба 7030М", 65.0, "Фарба 7030М", "11353KP1", "Фарба 7030М", "TEZ0670", "шт", "");

	public static CustomConst farba7031 = new CustomConst("Фарба 7031", 65.0, "Фарба 7031", "11354KP1", "Фарба 7031", "TEZ0671", "шт", "");

	public static CustomConst farba7032 = new CustomConst("Фарба 7032", 65.0, "Фарба 7032", "11355KP1", "Фарба 7032", "TEZ0672", "шт", "");

	public static CustomConst farba7032M = new CustomConst("Фарба 7032М", 65.0, "Фарба 7032М", "11356KP1", "Фарба 7032М", "TEZ0673", "шт", "");

	public static CustomConst farba7033 = new CustomConst("Фарба 7033", 65.0, "Фарба 7033", "11357KP1", "Фарба 7033", "TEZ0674", "шт", "");

	public static CustomConst farba7034 = new CustomConst("Фарба 7034", 65.0, "Фарба 7034", "11358KP1", "Фарба 7034", "TEZ0675", "шт", "");

	public static CustomConst farba7035 = new CustomConst("Фарба порошкова PE54AT 7035 189 GLX", 237.66, "Фарба порошкова PE54AT 7035 189 GLX", "129105KP1", "Фарба порошкова PE54AT 7035 189 GLX", "TEZ0676", "кг", "");

	public static CustomConst farba7035M = new CustomConst("Фарба 7035М", 65.0, "Фарба 7035М", "11360KP1", "Фарба 7035М", "TEZ0677", "шт", "");

	public static CustomConst farba7036 = new CustomConst("Фарба 7036", 65.0, "Фарба 7036", "11361KP1", "Фарба 7036", "TEZ0678", "шт", "");

	public static CustomConst farba7036M = new CustomConst("Фарба 7036М", 65.0, "Фарба 7036М", "11362KP1", "Фарба 7036М", "TEZ0679", "шт", "");

	public static CustomConst farba7037 = new CustomConst("Фарба 7037", 65.0, "Фарба 7037", "11363KP1", "Фарба 7037", "TEZ0680", "шт", "");

	public static CustomConst farba7037M = new CustomConst("Фарба 7037М", 65.0, "Фарба 7037М", "11364KP1", "Фарба 7037М", "TEZ0681", "шт", "");

	public static CustomConst farba7038 = new CustomConst("Фарба 7038", 65.0, "Фарба 7038", "11365KP1", "Фарба 7038", "TEZ0682", "шт", "");

	public static CustomConst farba7038M = new CustomConst("Фарба 7038М", 65.0, "Фарба 7038М", "11366KP1", "Фарба 7038М", "TEZ0683", "шт", "");

	public static CustomConst farba7039 = new CustomConst("Фарба 7039", 65.0, "Фарба 7039", "11367KP1", "Фарба 7039", "TEZ0684", "шт", "");

	public static CustomConst farba7040 = new CustomConst("Фарба порошкова PE54AT 7040 189 GLX", 234.0, "Фарба порошкова PE54AT 7040 189 GLX", "129858KP1", "Фарба порошкова PE54AT 7040 189 GLX", "TEZ0685", "кг", "");

	public static CustomConst farba7040M = new CustomConst("Фарба 7040М", 65.0, "Фарба 7040М", "11369KP1", "Фарба 7040М", "TEZ0686", "шт", "");

	public static CustomConst farba7042 = new CustomConst("Фарба 7042", 65.0, "Фарба 7042", "11370KP1", "Фарба 7042", "TEZ0687", "шт", "");

	public static CustomConst farba7042M = new CustomConst("Фарба 7042М", 65.0, "Фарба 7042М", "11371KP1", "Фарба 7042М", "TEZ0688", "шт", "");

	public static CustomConst farba7043 = new CustomConst("Фарба 7043", 65.0, "Фарба 7043", "11372KP1", "Фарба 7043", "TEZ0689", "шт", "");

	public static CustomConst farba7043M = new CustomConst("Фарба 7043М", 65.0, "Фарба 7043М", "11373KP1", "Фарба 7043М", "TEZ0690", "шт", "");

	public static CustomConst farba7044 = new CustomConst("Фарба 7044", 65.0, "Фарба 7044", "11374KP1", "Фарба 7044", "TEZ0691", "шт", "");

	public static CustomConst farba7044M = new CustomConst("Фарба 7044М", 65.0, "Фарба 7044М", "11375KP1", "Фарба 7044М", "TEZ0692", "шт", "");

	public static CustomConst farba7045 = new CustomConst("Фарба 7045", 65.0, "Фарба 7045", "11376KP1", "Фарба 7045", "TEZ0693", "шт", "");

	public static CustomConst farba7045M = new CustomConst("Фарба 7045М", 65.0, "Фарба 7045М", "11377KP1", "Фарба 7045М", "TEZ0694", "шт", "");

	public static CustomConst farba7046 = new CustomConst("Фарба 7046", 65.0, "Фарба 7046", "11378KP1", "Фарба 7046", "TEZ0695", "шт", "");

	public static CustomConst farba7046M = new CustomConst("Фарба 7046М", 65.0, "Фарба 7046М", "11379KP1", "Фарба 7046М", "TEZ0696", "шт", "");

	public static CustomConst farba7047 = new CustomConst("Фарба 7047", 65.0, "Фарба 7047", "11380KP1", "Фарба 7047", "TEZ0697", "шт", "");

	public static CustomConst farba7047M = new CustomConst("Фарба 7047М", 65.0, "Фарба 7047М", "11381KP1", "Фарба 7047М", "TEZ0698", "шт", "");

	public static CustomConst farba7048 = new CustomConst("Фарба 7048", 65.0, "Фарба 7048", "11382KP1", "Фарба 7048", "TEZ0699", "шт", "");

	public static CustomConst farba7152 = new CustomConst("Фарба 7152", 65.0, "Фарба 7152", "11383KP1", "Фарба 7152", "TEZ0700", "шт", "");

	public static CustomConst farba9018 = new CustomConst("Фарба 9018", 65.0, "Фарба 9018", "11384KP1", "Фарба 9018", "TEZ0701", "шт", "");

	public static CustomConst farba9018M = new CustomConst("Фарба 9018М", 65.0, "Фарба 9018М", "11385KP1", "Фарба 9018М", "TEZ0702", "шт", "");

	public static CustomConst farba8000 = new CustomConst("Фарба 8000", 65.0, "Фарба 8000", "11386KP1", "Фарба 8000", "TEZ0703", "шт", "");

	public static CustomConst farba8001 = new CustomConst("Фарба 8001", 65.0, "Фарба 8001", "11387KP1", "Фарба 8001", "TEZ0704", "шт", "");

	public static CustomConst farba8001M = new CustomConst("Фарба 8001М", 65.0, "Фарба 8001М", "11388KP1", "Фарба 8001М", "TEZ0705", "шт", "");

	public static CustomConst farba8002 = new CustomConst("Фарба 8002", 65.0, "Фарба 8002", "11389KP1", "Фарба 8002", "TEZ0706", "шт", "");

	public static CustomConst farba8003 = new CustomConst("Фарба 8003", 65.0, "Фарба 8003", "11390KP1", "Фарба 8003", "TEZ0707", "шт", "");

	public static CustomConst farba8003M = new CustomConst("Фарба 8003М", 65.0, "Фарба 8003М", "11391KP1", "Фарба 8003М", "TEZ0708", "шт", "");

	public static CustomConst farba8004 = new CustomConst("Фарба 8004", 65.0, "Фарба 8004", "11392KP1", "Фарба 8004", "TEZ0709", "шт", "");

	public static CustomConst farba8007 = new CustomConst("Фарба 8007", 65.0, "Фарба 8007", "11393KP1", "Фарба 8007", "TEZ0710", "шт", "");

	public static CustomConst farba8008 = new CustomConst("Фарба 8008", 65.0, "Фарба 8008", "11394KP1", "Фарба 8008", "TEZ0711", "шт", "");

	public static CustomConst farba8011 = new CustomConst("Фарба 8011", 65.0, "Фарба 8011", "11395KP1", "Фарба 8011", "TEZ0712", "шт", "");

	public static CustomConst farba8011M = new CustomConst("Фарба 8011М", 65.0, "Фарба 8011М", "11396KP1", "Фарба 8011М", "TEZ0713", "шт", "");

	public static CustomConst farba8012 = new CustomConst("Фарба 8012", 65.0, "Фарба 8012", "11397KP1", "Фарба 8012", "TEZ0714", "шт", "");

	public static CustomConst farba8014 = new CustomConst("Фарба 8014", 65.0, "Фарба 8014", "11398KP1", "Фарба 8014", "TEZ0715", "шт", "");

	public static CustomConst farba8014M = new CustomConst("Фарба 8014М", 65.0, "Фарба 8014М", "11399KP1", "Фарба 8014М", "TEZ0716", "шт", "");

	public static CustomConst farba8015 = new CustomConst("Фарба 8015", 65.0, "Фарба 8015", "11400KP1", "Фарба 8015", "TEZ0717", "шт", "");

	public static CustomConst farba8016 = new CustomConst("Фарба 8016", 65.0, "Фарба 8016", "11401KP1", "Фарба 8016", "TEZ0718", "шт", "");

	public static CustomConst farba8016M = new CustomConst("Фарба 8016М", 65.0, "Фарба 8016М", "11402KP1", "Фарба 8016М", "TEZ0719", "шт", "");

	public static CustomConst farba8017 = new CustomConst("Фарба 8017", 65.0, "Фарба 8017", "11403KP1", "Фарба 8017", "TEZ0720", "шт", "");

	public static CustomConst farba8017M = new CustomConst("Фарба 8017М", 65.0, "Фарба 8017М", "11404KP1", "Фарба 8017М", "TEZ0721", "шт", "");

	public static CustomConst farba8019 = new CustomConst("Фарба 8019", 65.0, "Фарба 8019", "11405KP1", "Фарба 8019", "TEZ0722", "шт", "");

	public static CustomConst farba8019M = new CustomConst("Фарба 8019М", 65.0, "Фарба 8019М", "11406KP1", "Фарба 8019М", "TEZ0723", "шт", "");

	public static CustomConst farba8022 = new CustomConst("Фарба 8022", 65.0, "Фарба 8022", "11407KP1", "Фарба 8022", "TEZ0724", "шт", "");

	public static CustomConst farba8022M = new CustomConst("Фарба 8022М", 65.0, "Фарба 8022М", "11408KP1", "Фарба 8022М", "TEZ0725", "шт", "");

	public static CustomConst farba8023 = new CustomConst("Фарба 8023", 65.0, "Фарба 8023", "11409KP1", "Фарба 8023", "TEZ0726", "шт", "");

	public static CustomConst farba8024 = new CustomConst("Фарба 8024", 65.0, "Фарба 8024", "11410KP1", "Фарба 8024", "TEZ0727", "шт", "");

	public static CustomConst farba8025 = new CustomConst("Фарба 8025", 65.0, "Фарба 8025", "11411KP1", "Фарба 8025", "TEZ0728", "шт", "");

	public static CustomConst farba8025M = new CustomConst("Фарба 8025М", 65.0, "Фарба 8025М", "11412KP1", "Фарба 8025М", "TEZ0729", "шт", "");

	public static CustomConst farba8028 = new CustomConst("Фарба 8028", 65.0, "Фарба 8028", "11413KP1", "Фарба 8028", "TEZ0730", "шт", "");

	public static CustomConst farba8028M = new CustomConst("Фарба 8028М", 65.0, "Фарба 8028М", "11414KP1", "Фарба 8028М", "TEZ0731", "шт", "");

	public static CustomConst GetCustomConstByName(string name)
	{
		CustomConst result = null;
		FieldInfo fieldInfo = Enumerable.FirstOrDefault<FieldInfo>(Enumerable.Where<FieldInfo>(Enumerable.Where<FieldInfo>((IEnumerable<FieldInfo>)typeof(Consts2).GetFields(BindingFlags.Static | BindingFlags.Public), (Func<FieldInfo, bool>)((FieldInfo f) => f.FieldType == typeof(CustomConst))), (Func<FieldInfo, bool>)((FieldInfo p) => ((CustomConst)p.GetValue(p)).MaterialName == name)));
		if (fieldInfo != null)
		{
			result = (CustomConst)fieldInfo.GetValue(fieldInfo);
		}
		return result;
	}

	public static IEnumerable<CustomConst> GetAllConsts()
	{
		return Enumerable.ToList<CustomConst>((IEnumerable<CustomConst>)Enumerable.OrderBy<CustomConst, string>(Enumerable.OfType<CustomConst>((IEnumerable)Enumerable.Select<FieldInfo, CustomConst>((IEnumerable<FieldInfo>)typeof(Consts2).GetFields(BindingFlags.Static | BindingFlags.Public), (Func<FieldInfo, CustomConst>)((FieldInfo f) => (CustomConst)f.GetValue(f)))), (Func<CustomConst, string>)((CustomConst c) => c.MaterialName)));
	}

	public static void FillDataBase()
	{
		IOrderedEnumerable<Const> val = Enumerable.OrderBy<Const, string>(Enumerable.Select<FieldInfo, Const>(Enumerable.Where<FieldInfo>((IEnumerable<FieldInfo>)typeof(Consts2).GetFields(BindingFlags.Static | BindingFlags.Public), (Func<FieldInfo, bool>)((FieldInfo f) => f.FieldType == typeof(CustomConst))), (Func<FieldInfo, Const>)((FieldInfo f) => ((CustomConst)f.GetValue(f)).ToConst(f.Name))), (Func<Const, string>)((Const c) => c.MaterialName));
		using UnitOfWork unitOfWork = new UnitOfWork();
		IEnumerable<Const> all = unitOfWork.ConstRepository.GetAll();
		foreach (Const item in all)
		{
			unitOfWork.ConstRepository.Delete(item);
		}
		unitOfWork.ReseedTable("[dbo].[Consts]");
		foreach (Const item2 in (IEnumerable<Const>)val)
		{
			unitOfWork.ConstRepository.Add(item2);
		}
		unitOfWork.Save();
	}

	public static void FillDataBaseWithNotAlreadyExistingItems()
	{
		IOrderedEnumerable<Const> val = Enumerable.OrderBy<Const, string>(Enumerable.Select<FieldInfo, Const>(Enumerable.Where<FieldInfo>((IEnumerable<FieldInfo>)typeof(Consts2).GetFields(BindingFlags.Static | BindingFlags.Public), (Func<FieldInfo, bool>)((FieldInfo f) => f.FieldType == typeof(CustomConst))), (Func<FieldInfo, Const>)((FieldInfo f) => ((CustomConst)f.GetValue(f)).ToConst(f.Name))), (Func<Const, string>)((Const c) => c.MaterialName));
		using UnitOfWork unitOfWork = new UnitOfWork();
		List<string> existingConstNames = Enumerable.ToList<string>(Enumerable.Select<Const, string>(unitOfWork.ConstRepository.GetAll(), (Func<Const, string>)((Const x) => x.NameInApp)));
		IEnumerable<Const> enumerable = Enumerable.Where<Const>((IEnumerable<Const>)val, (Func<Const, bool>)((Const c) => !existingConstNames.Contains(c.NameInApp)));
		if (!Enumerable.Any<Const>(enumerable))
		{
			return;
		}
		foreach (Const item in enumerable)
		{
			unitOfWork.ConstRepository.Add(item);
		}
		unitOfWork.Save();
	}

	public static void LoadConstsFromDb()
	{
		try
		{
			IEnumerable<Const> all = new UnitOfWork().ConstRepository.GetAll();
			IEnumerable<CustomConst> enumerable = Enumerable.Select<Const, CustomConst>(all, (Func<Const, CustomConst>)((Const c) => new CustomConst(c.Id, c.MaterialName, c.Price, c.MaterialNameFlight, c.Code1, c.MaterialName1C, c.Code2, c.OdVym1, c.OdVym2, c.NameInApp)));
			SetConsts(enumerable);
			BackupConstsToFile(Enumerable.ToList<CustomConst>(enumerable));
		}
		catch (Exception)
		{
			LoadConstsFromFile();
		}
	}

	public static void LoadConstsFromFile()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
	MessageBox.Show("Проблема з базою даних, константи взяті з файлу!");
		IEnumerable<CustomConst> enumerable = LoadFromFile();
		if (enumerable != null)
		{
			SetConsts(enumerable);
		}
	}

	private static void BackupConstsToFile(IEnumerable<CustomConst> consts)
	{
		File.WriteAllText("ConstsBackup.json", JsonConvert.SerializeObject(consts));
	}

	private static IEnumerable<CustomConst> LoadFromFile()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			return JsonConvert.DeserializeObject<IEnumerable<CustomConst>>(File.ReadAllText("ConstsBackup.json"));
		}
		catch
		{
			MessageBox.Show("Не змогло знайти файл \"ConstsBackup.json\". Перевірте його наявність.");
			return null;
		}
	}

	private static void SetConsts(IEnumerable<CustomConst> consts)
	{
		Dictionary<string, CustomConst> dictionary = Enumerable.ToDictionary<CustomConst, string, CustomConst>(consts, (Func<CustomConst, string>)((CustomConst c) => c.NameInApp), (Func<CustomConst, CustomConst>)((CustomConst c) => c));
		IEnumerable<FieldInfo> enumerable = Enumerable.Where<FieldInfo>((IEnumerable<FieldInfo>)typeof(Consts2).GetFields(BindingFlags.Static | BindingFlags.Public), (Func<FieldInfo, bool>)((FieldInfo f) => f.FieldType == typeof(CustomConst)));
		foreach (FieldInfo item in enumerable)
		{
			if (dictionary.ContainsKey(item.Name))
			{
				item.SetValue(null, dictionary[item.Name]);
			}
		}
	}
}
