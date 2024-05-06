<!DOCTYPE html>
<html lang="en">
<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Tính diện tích HCN</title>
   <link rel="stylesheet" type="text/css" href="giaodien.css">
</head>
<body>

<?php
   $Dientich = "";
   $Chieudai = "";
   $Chieurong = "";
   if(isset($_POST['btn_tinh']))
   {
      //Xử lý nếu nút Tính được nhấn
      $Chieudai = $_POST['Chieudai'];
      $Chieurong = $_POST['Chieurong'];
      $Dientich = $Chieudai * $Chieurong;
   }
?>

<section class="form_baitap">
   <form name="tindientichHCN" method="post" action="">
      <section class="title_baitap">
         <h3>TÍNH DIỆN TÍCH HÌNH CHỮ NHẬT</h3>
      </section>

      <section class="row_baitap">
         <label>Chiều dài: </label>
         <input type="text" name="Chieudai" value="<?php echo $Chieudai ?>" size="30" required pattern="[-+]?[0-9]*[.,]?[0-9]+">
      </section>

      <section class="row_baitap">
         <label>Chiều rộng: </label>
         <input type="text" name="Chieurong" value="<?php echo $Chieurong ?>" size="30" required pattern="[-+]?[0-9]*[.,]?[0-9]+">
      </section>

      <section class="row_baitap">
         <label>Diện tích: </label>
         <input class="readonly" type="text" name="Dientich" value="<?php echo $Dientich ?>" size="30" readonly>
      </section>

      <section>
         <input class="btn_tinh" type="submit" value="Tính" name="btn_tinh">
      </section>
   </form>
</section>
</body>
</html>