window.showToaster = function (type, message) {
  if (type == "success") {
    toastr.success(message);
  }
  if (type == "error") {
    toastr.error(message);
  }
};

window.showSweerAlert = function (type, message) {
  if (type == "success") {
    Swal.fire({
      title: "Good job!",
      text: message,
      icon: "success",
    });
  }
  if (type == "error") {
    Swal.fire({
      title: "Oops...",
      text: message,
      icon: "error",
    });
  }
};
