# OnlineClassManager3
CARA PENGGUNAAN ONLINE CLASS MANAGER SETUPER


1. Ekstrak file berekstensi rar
2. Jalankan setup.exe
3. Klik Install

CARA PENGGUNAAN FILE .EXE
1. Masuk ke folder Kuliah Manager 
2. Klik Kuliah Manager.sln

LOGIN 
1. Login dengan 
- Username: 0User dan Password: 0Pass
  atau
- Username: 1User dan Password: 1Pass

2. Pilih reminder untuk KELAS atau TUGAS

UNTUK REMINDER KELAS
1. Masukkan nama matkul, link meeting, link presensi, link drive, hari, jam, dan menit (WAJIB SEMUA)
2. Klik button ADD untuk menambahkan ke dalam tabel
3.   Alarm dan pop-up notification akan muncul
- saat hari dan jam di pojok kiri atas sesuai dengan hari dan jam yang Anda input
- 10 menit sebelum waktu yang Anda input

4. Agar tidak repot, Anda juga bisa menge-klik nama kelas yang sudah ada pada tabel dan mengganti
keterangan, hari, dan tanggal sesuai keinginan, kemudian klik EDIT button

5. Setelah meng-input data, kembali ke HOME dengan menekan Back button (di kiri bawah), 
lalu masuk lagi ke page Class Manager agar notifikasi dapat berjalan. 

6. Alarm dan pop-up notification akan muncul saat hari dan jam di pojok kiri atas sesuai
dengan hari dan jam yang Anda input

<br>
UNTUK REMINDER TUGAS <br>
1. Masukkan nama tugas, nama kelas, deskripsi, due day, due hour, dan due minute <br>
2. Klik button ADD untuk menambahkan ke dalam tabel <br>
3. Alarm dan pop-up notification akan muncul: <br>
- saat hari dan jam di pojok kiri atas sesuai dengan hari dan jam yang Anda input <br>
- 1 hari sebelum hari dan jam yang Anda input

4. Agar tidak repot, Anda juga bisa menge-klik nama kelas yang sudah ada pada tabel dan mengganti
keterangan, hari, dan tanggal sesuai keinginan, kemudian klik EDIT button

5. Setelah meng-input data, kembali ke HOME dengan menekan Back button (di kiri bawah), 
lalu masuk lagi ke page Task Manager agar notifikasi dapat berjalan. 

6. Alarm dan pop-up notification akan muncul saat hari dan jam di pojok kiri atas sesuai
dengan hari dan jam yang Anda input




<br><br>
Berikut adalah Diagram Database program
<br>
![DBDiagram](DBDiagram.png)
<br>
Terdapat 2 tabel pada pada database program ini yakni ClassTbl dan TaskTbl. ClassTbl menyimpan data kelas online yang harus dihadiri oleh mahasiswa. Data yang disimpan antara lain 
ClassName (nama mata kuliah), MeetingLink (link online class), AttendanceLink (link absen), DriveLink (link google drive mata kuliah yang dipilih), Day (Hari), Hour, dan Min (waktu kuliah dalam jam dan waktu). TaskTbl merupakan tabel yang menyimpan data-data tugas mahasiswa antara lain: DueDay, DueHour, dan DueMin untuk menyimpan hari, jam, dan menit deadline tugas, TaskName untuk menyimpan nama tugas, ClassName untuk menyimpan nama mata kuliah tugas, dan Desc untuk menyimpan penjelasan lengkap tugas yang harus dikerjakan.
<br>
<br>
Berikut adalah class diagram program 
<br>
![ClassDiagram](ClassDiagram.png)

<br>
<br>
Keterangan:
<br>
Database dengan Entity Framework sudah terkoneksi dengan program. Contoh penggunaannya adalah dengan melakukan Adding kelas (matakuliah) dan melakukan searching nama matakuliah.

